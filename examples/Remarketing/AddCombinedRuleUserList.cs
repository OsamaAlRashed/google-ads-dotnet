// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Linq;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;
using static Google.Ads.GoogleAds.V6.Enums.UserListStringRuleItemOperatorEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.UserListCombinedRuleOperatorEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.UserListPrepopulationStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.UserListMembershipStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example creates a rule-based user list defined by a combination of rules for users
    /// who have visited two different pages of a website.
    /// </summary>
    public class AddCombinedRuleUserList : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddCombinedRuleUserList codeExample = new AddCombinedRuleUserList();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a rule-based user list defined by a combination of rules " +
            "for users who have visited two different pages of a website.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the UserListServiceClient.
            UserListServiceClient userListServiceClient =
                client.GetService(Services.V6.UserListService);

            // Creates a rule targeting any user that visited a url that equals
            // 'http://example.com/example1'.
            UserListRuleInfo userVisitedSite1RuleInfo =
                BuildVisitedSiteRuleInfo("http://example.com/example1");

            // Creates a rule targeting any user that visited a url that equals
            // 'http://example.com/example2'.
            UserListRuleInfo userVisitedSite2RuleInfo =
                BuildVisitedSiteRuleInfo("http://example.com/example2");

            // Creates the user list where "Visitors of a page who did visit another page".
            // To create a user list where "Visitors of a page who did not visit another page",
            // change the UserListCombinedRuleOperator from .And to .AndNot.
            CombinedRuleUserListInfo combinedRuleUserListInfo = new CombinedRuleUserListInfo()
            {
                LeftOperand = userVisitedSite1RuleInfo,
                RightOperand = userVisitedSite2RuleInfo,
                RuleOperator = UserListCombinedRuleOperator.And
            };

            // Defines a representation of a user list that is generated by a rule.
            RuleBasedUserListInfo ruleBasedUserListInfo = new RuleBasedUserListInfo()
            {
                // Optional: To include past users in the user list, set the prepopulation_status to
                // REQUESTED.
                PrepopulationStatus = UserListPrepopulationStatus.Requested,
                CombinedRuleUserList = combinedRuleUserListInfo
            };

            // Creates a user list.
            UserList userList = new UserList()
            {
                Name = "All visitors to http://example.com/example1 AND " +
                       $"http://example.com/example2 #{ExampleUtilities.GetShortRandomString()}",
                Description = "Visitors of both http://example.com/example1 AND " +
                              "http://example.com/example2",
                MembershipStatus = UserListMembershipStatus.Open,
                MembershipLifeSpan = 365L,
                RuleBasedUserList = ruleBasedUserListInfo
            };

            // Creates the operation.
            UserListOperation operation = new UserListOperation()
            {
                Create = userList
            };

            try
            {
                // Adds the new user list and prints the result.
                MutateUserListsResponse response = userListServiceClient.MutateUserLists
                    (customerId.ToString(), new[] { operation });
                Console.WriteLine("Created user list with resource name:" +
                                  $"{response.Results.First().ResourceName}");
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        /// <summary>
        /// Creates and returns a UserListRuleInfo object targeting a visit to a specified URL.
        /// </summary>
        /// <param name="url">The URL at which the rule will be targeted.</param>
        /// <returns>A populated UserListRuleInfo object.</returns>
        private UserListRuleInfo BuildVisitedSiteRuleInfo(string url)
        {
            // Creates a rule targeting any user that visited the specified URL.
            UserListRuleItemInfo userVisitedSiteRule = new UserListRuleItemInfo()
            {
                // Uses a built-in parameter to create a domain URL rule.
                Name = "url__",
                StringRuleItem = new UserListStringRuleItemInfo()
                {
                    Operator = UserListStringRuleItemOperator.Equals,
                    Value = url
                }
            };

            // Creates a UserListRuleInfo object containing the new rule.
            UserListRuleInfo userVisitedSiteRuleInfo = new UserListRuleInfo()
            {
                RuleItemGroups =
                {
                    new UserListRuleItemGroupInfo()
                    {
                        RuleItems = {userVisitedSiteRule}
                    }
                }
            };

            return userVisitedSiteRuleInfo;
        }
    }
}