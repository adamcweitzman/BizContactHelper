using BizContactHelper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizContactHelper.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BizContactHelperContext context)
        {
            context.Database.EnsureCreated();

            // Are there contacts in the db?
            if (context.Contacts.Any())
            {
                return; 
            }
              
            var contacts = new Contact[]
            {
                new SalesContact{ City = "San Francisco", Email="bud@buddy.com", Name="Buddy Guy", PhoneNumber="4158675309", State="CA", Street="Ridgewood Ave", Zipcode="90210", FollowUpDate=DateTime.Now },
                new DeveloperContact{ City = "Savannah", Email="jon@johnson.com", Name="John Johnson", PhoneNumber="4158675239", State="GA", Street="Cool Ave", Zipcode="90210", StrongestLanguage=Languages.Ruby  },
                new SalesContact{ City = "San Francisco", Email="bud@buddy.com", Name="Buddy Guy", PhoneNumber="4158675309", State="CA", Street="Ridgewood Ave", Zipcode="90210", FollowUpDate=DateTime.Now },
                new DeveloperContact{ City = "Savannah", Email="jon@johnson.com", Name="John Johnson", PhoneNumber="4158675239", State="GA", Street="Cool Ave", Zipcode="90210", StrongestLanguage=Languages.Ruby  },
                new SalesContact{ City = "San Francisco", Email="bud@buddy.com", Name="Buddy Guy", PhoneNumber="4158675309", State="CA", Street="Ridgewood Ave", Zipcode="90210", FollowUpDate=DateTime.Now },
                new DeveloperContact{ City = "Savannah", Email="jon@johnson.com", Name="John Johnson", PhoneNumber="4158675239", State="GA", Street="Cool Ave", Zipcode="90210", StrongestLanguage=Languages.Ruby  },
                new SalesContact{ City = "San Francisco", Email="bud@buddy.com", Name="Buddy Guy", PhoneNumber="4158675309", State="CA", Street="Ridgewood Ave", Zipcode="90210", FollowUpDate=DateTime.Now },
                new DeveloperContact{ City = "Savannah", Email="jon@johnson.com", Name="John Johnson", PhoneNumber="4158675239", State="GA", Street="Cool Ave", Zipcode="90210", StrongestLanguage=Languages.Ruby  },
                new SalesContact{ City = "San Francisco", Email="bud@buddy.com", Name="Buddy Guy", PhoneNumber="4158675309", State="CA", Street="Ridgewood Ave", Zipcode="90210", FollowUpDate=DateTime.Now },
                new DeveloperContact{ City = "Savannah", Email="jon@johnson.com", Name="John Johnson", PhoneNumber="4158675239", State="GA", Street="Cool Ave", Zipcode="90210", StrongestLanguage=Languages.Ruby  },
            };
            foreach (Contact contact in contacts)
            {
                context.Contacts.Add(contact);
            }
            context.SaveChanges();

        }
    }
}