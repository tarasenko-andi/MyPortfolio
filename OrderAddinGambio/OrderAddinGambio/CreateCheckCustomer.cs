using Customers;
using System.Collections.Generic;

namespace OrderAddinGambio
{
    class CreateCheckCustomer
    {
        public static void createCheckCustomer(out Customers.Customer customer)
        {
            AddonValues addonValues = new AddonValues(new string[] { "test_value" });
            IList<AddonValues> addonValueses = null;
            Address address = new Address(
                additionalAddressInfo: "6. Etage",
                b2bStatus: false,
                city: "Test City",
                company: "Test Company",
                countryId: "14",
                houseNumber: "5",
                postcode: "3452",
                street: "Test Street",
                suburb: "Test Suburb",
                zoneId: "95");
            customer = new Customers.Customer(
            addonValues: addonValueses,
            address: address,
            dateOfBirth: "1985-02-13",
            email: "newemail@gmail.com7",
            fax: "54646464",
            firstname: "John",
            gender: "m",
            isGuest: false,
            lastname: "Doe",
            number: "5454",
            password: "827ccb0eea8a706c4c34a16891f84e7b",
            statusId: "1",
            telephone: "2343948798345",
            type: "registree",
            vatNumber: "444445454545",
            vatNumberStatus: 1);
        }
    }
}
