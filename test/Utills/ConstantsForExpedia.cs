namespace Assignment.Utills
{
    class ConstantsForExpedia
    {
        public const string ExpediaUrl = "https://www.expedia.com/";
        public const string ExpediaTitle = "Expedia Travel: Search Hotels, Cheap Flights, Car Rentals & Vacations";
        public const string FlightsBtn = "//span[contains(text(),'Flights')]";
        public const string MultiCityBtn = "//label[@id='flight-type-multi-dest-label-hp-flight']";

        public const string FirstSourcePort = "//input[@id='flight-origin-hp-flight']";
        public const string FirstDestinationPort = "//input[@id='flight-destination-hp-flight']";
        public const string FirstDepartDate = "//input[@id='flight-departing-single-hp-flight']";

        public const string SecondsourcePort = "//input[@id='flight-2-origin-hp-flight']";
        public const string SecondDestinationPort = "//input[@id='flight-2-destination-hp-flight']";
        public const string SecondDepartDate = "//input[@id='flight-2-departing-hp-flight']";

        public const string ThirdSourcePort = "//input[@id='flight-3-origin-hp-flight']";
        public const string ThirdDestinationPort = "//input[@id='flight-3-destination-hp-flight']";
        public const string ThirdDepartDate = "//input[@id='flight-3-departing-hp-flight']";

        public const string AddAnotherFlight = "//a[@id='add-flight-leg-hp-flight']";
        public const string SearchBtn = "//form[@id='gcw-flights-form-hp-flight']//button[@class='btn-primary btn-action gcw-submit']";
        public const string AddPass = "//div[@id='traveler-selector-hp-flight']//button[@class='trigger-utility menu-trigger btn-utility btn-secondary dropdown-toggle theme-standard pin-left menu-arrow gcw-component gcw-traveler-amount-select gcw-component-initialized']";
        public const string AddSymbol = "//body[@class='wrap cf aoa-enabled']/meso-native-marquee/section[@id='WizardHero']/div[@id='hero-banner']/div[@class='hero-banner-gradient native-marquee']/div[@class='cols-row hero-banner-inner']/section[@id='wizardSection']/div[@class='hero-banner-box siteId-1 cf hideClassicDcol']/div[@id='wizard-tabs']/div[@class='tabs-container col']/section[@id='section-flight-tab-hp']/form[@id='gcw-flights-form-hp-flight']/fieldset[@class='room-data']/div[@class='cols-nested']/div[@class='ab25184-traveler-wrapper-flight available-for-flights gcw-clear-both']/div[@id='traveler-selector-hp-flight']/div[@class='menu-bar gcw-travel-selector-wrapper']/ul[@class='menu-bar-inner']/li[@class='open']/div[@class='menu sticky gcw-menu']/div[@class='menu-main']/div[@class='traveler-selector-sinlge-room-data traveler-selector-room-data']/div[@class='uitk-grid step-input-outside gcw-component gcw-component-step-input gcw-step-input gcw-component-initialized']/div[4]";
        public const string PassCount = "//body[@class='wrap cf aoa-enabled']/meso-native-marquee/section[@id='WizardHero']/div[@id='hero-banner']/div[@class='hero-banner-gradient native-marquee']/div[@class='cols-row hero-banner-inner']/section[@id='wizardSection']/div[@class='hero-banner-box siteId-1 cf hideClassicDcol']/div[@id='wizard-tabs']/div[@class='tabs-container col']/section[@id='section-flight-tab-hp']/form[@id='gcw-flights-form-hp-flight']/fieldset[@class='room-data']/div[@class='cols-nested']/div[@class='ab25184-traveler-wrapper-flight available-for-flights gcw-clear-both']/div[@id='traveler-selector-hp-flight']/div[@class='menu-bar gcw-travel-selector-wrapper']/ul[@class='menu-bar-inner']/li[@class='open']/div[@class='menu sticky gcw-menu']/div[@class='menu-main']/div[@class='traveler-selector-sinlge-room-data traveler-selector-room-data']/div[@class='uitk-grid step-input-outside gcw-component gcw-component-step-input gcw-step-input gcw-component-initialized']/div[3]";

        public const string SelectFirstFlight = "//li[1]//div[1]//div[1]//div[2]//div[1]//div[2]//button[1]";
        public const string SelectSecondFlight = "//li[1]//div[1]//div[1]//div[2]//div[1]//div[2]//button[1]";
        public const string SelectThirdFlight = "//li[1]//div[1]//div[1]//div[2]//div[1]//div[2]//button[1]";
        public const string ContinueBookingBtn = "/html[1]/body[1]/main[1]/section[1]/form[1]";

        public const string ConfFirstFlight = "//div[contains(text(),'Delhi (DEL) to Goa (GOI)')]";
        public const string confSecondFlight = "//div[contains(text(),'Goa (GOI) to Mumbai (BOM)')]";
        public const string ConfThirdFlight = "//div[contains(text(),'Mumbai (BOM) to Delhi (DEL)')]";
        public const string Amount1 = "//span[@id='totalPriceForPassenger1']";
        public const string FinalAmount = "//span[@id='totalPriceForTrip']";

    }
}
