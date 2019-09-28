using AllOrders;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAddinGambio
{
    class CreateCheckOrder
    {
        public static void createOrder(out Order order) { 
        ShippingType shippingType = new ShippingType("Pauschale Versandkosten (Standar)", "flat_flat");
        PaymentType paymentType = new PaymentType("cash", "cash");
        Status status = new Status(0, "Admin", "admin_status.gif", 0, false);
            AllOrders.Customer customer = new AllOrders.Customer(
            id: 1,
            number: "",
            email: "info@wienkiew.com",
            phone: "0421 - 22 34 678",
            vatId: "",
            status: status);
        Customer2 customer2 = new Customer2("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
        Billing billing = new Billing("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
        Delivery delivery = new Delivery("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
        Addresses addresses = new Addresses(customer2, billing, delivery);
        Attributes attributes = new Attributes(id: 1, name: "Farbe", value: "rot", price: 0, priceType: "+", optionId: 1, optionValueId: 1, combisId: null);
        AddonValues addonValues = new AddonValues(2, 1);
            AddonValues[] addonValueses = new AddonValues[] { addonValues };
            DownloadInformation downloadInformation = new DownloadInformation(countAvailable: 14, filename: "Dokument.pdf", maxDaysAllowed: 5);
        Item item = new Item(
            id: 3186,
            model: "Model",
            name: "ItemName",
            quantity: 1,
            price: 100,
            finalPrice: 100,
            tax: 20,
            isTaxAllowed: true,
            discount: 0,
            shippingTimeInformation: "",
            checkoutInformation: "",
            attributes: attributes,
            downloadInformation: downloadInformation,
            addonValues: addonValueses,
            quantityUnitName: "Liter"); ;
            Item[] items = new Item[] { item };
        Total total = new Total(id: 1, title: "Zwischensumme, netto:", value: 120, valueText: "120,00 EUR", classs: "ot_subtotal", sortOrder: 10);
        //Total total1 = new Total(id: 2523, title: "Selbstabholung (Selbstabholung der Ware in unserer Geschäftsstelle.):", value: 120, valueText: " 0,00 EUR", classs: "ot_shipping", sortOrder: 30);
        //Total total2 = new Total(id: 2523, title: "<b>Summe, netto</b>", value: 120, valueText: "<b> 120,00 EUR</b>", classs: "ot_total", sortOrder: 99);
        Total[] totals = new Total[] { total/*, total1, total2*/ };
        StatusHistory statusHistory = new StatusHistory(id: 1181, statusId: 149, dateAdded: "2019-09-21 11:22:39", comment: "", customerNotified: true);
        StatusHistory[] statusHistories = new StatusHistory[] { statusHistory };
        AddonValues2 addonValues2 = new AddonValues2("", "", "", "", "", "", "", "", "0", "0");
            AddonValues2[] addonValues2s = new AddonValues2[] { addonValues2 };
            //-------------------------------------------------------------------------->
            order = new Order(
            id: 400705,
            statusId: 149,
            purchaseDate: "2019-09-21 11:22:39",
            currencyCode: "EUR",
            languageCode: "DE",
            comment: "Coment",
            totalWeight: 15,
            paymentType: paymentType,
            shippingType: shippingType,
            customer: customer,
            addresses: addresses,
            items: items,
            totals: totals,
            statusHistory: statusHistories,
            addonValues: addonValues2s);
        }
        public static void createOrder2(out Order order)
        {
            ShippingType shippingType = new ShippingType("", "");
            PaymentType paymentType = new PaymentType("", "");
            Status status = new Status(1, "", "", 0, false);
            AllOrders.Customer customer = new AllOrders.Customer(
                id: 0,
                number: "",
                email: "info@wienkiew.com4",
                phone: "",
                vatId: "",
                status: status);
            Customer2 customer2 = new Customer2("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
            Billing billing = new Billing("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
            Delivery delivery = new Delivery("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
            Addresses addresses = new Addresses(customer2, billing, delivery);
            Attributes attributes = new Attributes(id: 1, name: "Farbe", value: "rot", price: 0, priceType: "+", optionId: 1, optionValueId: 1, combisId: 1);
            AddonValues addonValues = new AddonValues(2, 1);
            AddonValues[] addonValueses = new AddonValues[] { addonValues };
            DownloadInformation downloadInformation = new DownloadInformation(countAvailable: 14, filename: "", maxDaysAllowed: 5);
            Item item = new Item(
                id: 3186,
                model: "Model",
                name: "ItemName",
                quantity: 1,
                price: 100,
                finalPrice: 100,
                tax: 20,
                isTaxAllowed: true,
                discount: 0,
                shippingTimeInformation: "",
                checkoutInformation: "",
                attributes: attributes,
                downloadInformation: downloadInformation,
                addonValues: addonValueses,
                quantityUnitName: "Liter"); ;
            Item[] items = new Item[] { item };
            Total total = new Total(id: 1, title: "Zwischensumme, netto:", value: 120, valueText: "120,00 EUR", classs: "ot_subtotal", sortOrder: 10);
            Total[] totals = new Total[] { total/*, total1, total2*/ };
            StatusHistory statusHistory = new StatusHistory(id: 1181, statusId: 149, dateAdded: "2019-09-21 11:22:39", comment: "", customerNotified: true);
            StatusHistory[] statusHistories = new StatusHistory[] { statusHistory };
            AddonValues2 addonValues2 = new AddonValues2("", "", "", "", "", "", "", "", "0", "0");
            AddonValues2[] addonValues2s = new AddonValues2[] { addonValues2 };
            //-------------------------------------------------------------------------->
            order = new Order(
                id: 400705,
                statusId: 149,
                purchaseDate: "2019-09-21 11:22:39",
                currencyCode: "EUR",
                languageCode: "DE",
                comment: "Coment",
                totalWeight: 15,
                paymentType: paymentType,
                shippingType: shippingType,
                customer: customer,
                addresses: addresses,
                items: items,
                totals: totals,
                statusHistory: statusHistories,
                addonValues: addonValues2s);
        }
        public static void createOrder3(out Order order)
        {
            ShippingType shippingType = new ShippingType("Ship", "Ship");
            PaymentType paymentType = new PaymentType("Payment", "Payment");
            Status status = new Status(2, "Neuer Kunde", "customer_status.gif", 0, false);
            AllOrders.Customer customer = new AllOrders.Customer(
                id: 372,
                number: "",
                email: "info@wienkiew.com4",
                phone: "",
                vatId: "",
                status: status);
            Customer2 customer2 = new Customer2("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
            Billing billing = new Billing("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
            Delivery delivery = new Delivery("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
            Addresses addresses = new Addresses(customer2, billing, delivery);
            Attributes attributes = null;
            AddonValues addonValues = null;
            AddonValues[] addonValueses = null;
            DownloadInformation downloadInformation = null;
            Item item = new Item(
                id: 3186,
                model: "Model",
                name: "ItemName",
                quantity: 1,
                price: 100,
                finalPrice: 100,
                tax: 20,
                isTaxAllowed: true,
                discount: 0,
                shippingTimeInformation: "",
                checkoutInformation: "",
                attributes: attributes,
                downloadInformation: downloadInformation,
                addonValues: addonValueses,
                quantityUnitName: "Liter"); ;
            Item[] items = new Item[] { item };
            Total total = null;
            Total[] totals = null;
            StatusHistory statusHistory = null;
            StatusHistory[] statusHistories = null;
            AddonValues2 addonValues2 = null;
            AddonValues2[] addonValues2s = null;
            //-------------------------------------------------------------------------->
            order = new Order(
                id: 400708,
                statusId: 149,
                purchaseDate: "2019-09-21 11:22:39",
                currencyCode: "EUR",
                languageCode: "DE",
                comment: "Coment",
                totalWeight: 15,
                paymentType: paymentType,
                shippingType: shippingType,
                customer: customer,
                addresses: addresses,
                items: items,
                totals: totals,
                statusHistory: statusHistories,
                addonValues: addonValues2s);
        }
        public static void createOrder4(out Order order)
        {
            ShippingType shippingType = new ShippingType("Ship", "Ship");
            PaymentType paymentType = new PaymentType("Payment", "Payment");
            Status status = new Status(2, "Neuer Kunde", "customer_status.gif", 0, false);
            AllOrders.Customer customer = new AllOrders.Customer(
                id: 372,
                number: "",
                email: "info@wienkiew.com4",
                phone: "",
                vatId: "",
                status: status);
            Customer2 customer2 = new Customer2("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
            Billing billing = new Billing("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
            Delivery delivery = new Delivery("m", "Firstname", "Lastname", "Company", "Street", "123", "", "", "28219", "Bremen", 1, 1, false);
            Addresses addresses = new Addresses(customer2, billing, delivery);
            Attributes attributes = null;
            AddonValues addonValues = null;
            AddonValues[] addonValueses = null;
            DownloadInformation downloadInformation = null;
            Item item = new Item(
                id: 3186,
                model: "Model",
                name: "ItemName",
                quantity: 1,
                price: 100,
                finalPrice: 100,
                tax: 20,
                isTaxAllowed: true,
                discount: 0,
                shippingTimeInformation: "",
                checkoutInformation: "",
                attributes: attributes,
                downloadInformation: downloadInformation,
                addonValues: addonValueses,
                quantityUnitName: "Liter"); ;
            Item[] items = new Item[] { item };
            Total total = new Total(id: 1, title: "Zwischensumme, netto:", value: 120, valueText: "120,00 EUR", classs: "ot_subtotal", sortOrder: 10);
            Total total1 = new Total(id: 2523, title: "Selbstabholung (Selbstabholung der Ware in unserer Geschäftsstelle.):", value: 120, valueText: " 0,00 EUR", classs: "ot_shipping", sortOrder: 30);
            Total total2 = new Total(id: 2523, title: "<b>Summe, netto</b>", value: 120, valueText: "<b> 120,00 EUR</b>", classs: "ot_total", sortOrder: 99);
            Total[] totals = new Total[] { total, total1, total2 };
            StatusHistory statusHistory = null;
            StatusHistory[] statusHistories = null;
            AddonValues2 addonValues2 = null;
            AddonValues2[] addonValues2s = null;
            //-------------------------------------------------------------------------->
            order = new Order(
                id: 400708,
                statusId: 149,
                purchaseDate: "2019-09-21 11:22:39",
                currencyCode: "EUR",
                languageCode: "DE",
                comment: "Coment",
                totalWeight: 15,
                paymentType: paymentType,
                shippingType: shippingType,
                customer: customer,
                addresses: addresses,
                items: items,
                totals: totals,
                statusHistory: statusHistories,
                addonValues: addonValues2s);
        }
    }
}
