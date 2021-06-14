// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceUpdate;
using Azure.ResourceManager.DeviceUpdate.Models;

namespace sample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ArmClient armClient = new ArmClient(new Uri("http://example.com"), new DefaultAzureCredential(), new ArmClientOptions());
            Subscription subscription = armClient.DefaultSubscription;
            ResourceGroup resourceGroup = (await subscription.GetResourceGroups().Construct(LocationData.WestUS2).CreateOrUpdateAsync("resourceGroupName")).Value;
            AccountContainer accountContainer = resourceGroup.GetAccounts();

            // Create Account
            Account account = await accountContainer.CreateOrUpdateAsync("accountName", new AccountData(LocationData.WestUS2));

            // Get Account
            account = await account.GetAsync();

            // Delete Account
            await account.DeleteAsync();

            // Get list of Accounts
            await foreach (Account accountInfo in subscription.ListAccountAsync())
            {
                Console.WriteLine(accountInfo);
            }
        }
    }
}
