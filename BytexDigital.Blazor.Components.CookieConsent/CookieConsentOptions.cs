using System;
using System.Collections.Generic;
using BytexDigital.Blazor.Components.CookieConsent.Dialogs.Prompts;

namespace BytexDigital.Blazor.Components.CookieConsent
{
    public class CookieConsentOptions
    {
        /// <summary>
        /// Revision of the cookie policy the user agrees to. If the user's agreed to policy number is any different than the currently configured, the prompt for consent will appear again.
        /// </summary>
        public int Revision { get; set; } = 1;

        /// <summary>
        /// Automatically runs the consent check once the CookieConsentHandler component was rendered. This will also activate any scripts inside the DOM. If user consent is required, the consent modal will appear.
        /// <para>If you disable this option, you must manually call <see cref="CookieConsentService.NotifyPageLoadedAsync"/> once you wish to run the checks.</para>
        /// </summary>
        public bool AutomaticallyShow { get; set; } = true;

        /// <summary>
        /// The default language code the components will look for when localization if the currently configured language does not havea localized message.
        /// </summary>
        public string DefaultLocalizationCode { get; set; } = "en";

        /// <summary>
        /// URL to your cookie policy. Will always be opened in a new tab.
        /// </summary>
        public string PolicyUrl { get; set; } = "#";

        /// <summary>
        /// Cookie specific options.
        /// </summary>
        public CookieConsentCookieOptions CookieOptions { get; set; } = new CookieConsentCookieOptions();

        /// <summary>
        /// Behavior settings specific to <see cref="CookieConsentCheck"/>.
        /// </summary>
        public CookieConsentCheckOptions CheckOptions { get; set; } = new CookieConsentCheckOptions();

        /// <summary>
        /// Cookie consent prompt variant to use. Defaults to <see cref="BytexDigital.Blazor.Components.CookieConsent.CookieConsentDefaultPromptVariant"/>.
        /// </summary>
        public CookieConsentPromptVariantBase ConsentPromptVariant { get; set; } =
            new CookieConsentDefaultPromptVariant();

        /// <summary>
        /// Title text of the consent modal.
        /// </summary>
        public Dictionary<string, string> ConsentTitleText { get; set; } = new()
        {
            ["en"] = "We use cookies",
            ["de"] = "Wir verwenden Cookies",
            ["nl"] = "We gebruiken cookies",
            ["es"] = "Nosotras usamos cookies",
            ["fr"] = "On utilises des cookies"
        };

        /// <summary>
        /// Description text of the consent modal.
        /// </summary>
        public Dictionary<string, string> ConsentDescriptionText { get; set; } = new()
        {
            ["en"] = "This website uses cookies to improve your experience.",
            ["de"] = "Diese Webseite verwendet Cookies, um Ihre Erfahrung zu verbessern.",
            ["nl"] = "Deze website maakt gebruik van cookies om uw ervaring te verbeteren.",
            ["es"] = "Este sitio web utiliza cookies para una mejor experiencia.",
            ["fr"] = "Ce site web utilice des cookies pour améliorer votre visite."
        };

        /// <summary>
        /// "Accept all" text. Used in multiple places.
        /// </summary>
        public Dictionary<string, string> ConsentAcceptAllText { get; set; } = new()
        {
            ["en"] = "Accept all",
            ["de"] = "Alle akzeptieren",
            ["nl"] = "Alles accepteren.",
            ["es"] = "Aceptar todas.",
            ["fr"] = "Tout accepter."
        };

        /// <summary>
        /// "I understand!" text. Used, if there are no preferences to configure since there is only REQUIRED cookie categories.
        /// </summary>
        public Dictionary<string, string> ConsentAcknowledgeText { get; set; } = new()
        {
            ["en"] = "I understand!",
            ["de"] = "Alles klar!",
            ["nl"] = "Ik begrijp het!",
            ["es"] = "Entiendo!",
            ["fr"] = "Je comprends!"
        };

        /// <summary>
        /// "Decline" or "Necessary only" text. Indicates that the user will only agree to the minimum amount of cookies necessary.
        /// </summary>
        public Dictionary<string, string> ConsentNecessaryOnlyText { get; set; } = new()
        {
            ["en"] = "Decline",
            ["de"] = "Ablehnen",
            ["nl"] = "Afwijzen",
            ["es"] = "Rechazar",
            ["fr"] = "Refuser"
        };
        
        /// <summary>
        /// "Manage preferences" text. Used in multiple places.
        /// </summary>
        public Dictionary<string, string> OpenPreferencesText { get; set; } = new()
        {
            ["en"] = "Manage preferences",
            ["de"] = "Präferenzen ändern",
            ["nl"] = "Voorkeuren wijzigen",
            ["es"] = "Administrar preferencias",
            ["fr"] = "Gérer les préférences"
        };
        
        /// <summary>
        /// Title text of the settings modal.
        /// </summary>
        public Dictionary<string, string> SettingsTitleText { get; set; } = new()
        {
            ["en"] = "Your cookie preferences",
            ["de"] = "Ihre Cookie Präferenzen",
            ["nl"] = "Uw cookie instellingen",
            ["es"] = "Sus preferencias de cookies",
            ["fr"] = "Vos préférences de cookies"
        };

        /// <summary>
        /// Description text of the settings modal.
        /// </summary>
        public Dictionary<string, string> SettingsDescriptionText { get; set; } = new()
        {
            ["en"] = "We use cookies to ensure basic functionality of the website and to enhance your online experience. For each category, you may choose to opt-in/out whenever you want.",
            ["de"] = "Wir nutzen Cookies für grundlegende Funktionalitäten unserer Webseite und zum Verbessern Ihrer Nutzererfahrung. Für jede Kategorie können Sie individuell Ihre Zustimmung erteilen.",
            ["nl"] = "We gebruiken cookies om de basisfunctionaliteit van de website te garanderen en om uw online ervaring te verbeteren. Voor elke categorie kunt u ervoor kiezen om u aan/uit te melden wanneer u maar wilt.",
            ["es"] = "Utilizamos cookies para garantizar la funcionalidad básica del sitio web y mejorar su experiencia en línea.Para cada categoría, puede optar por participar o excluirse cuando lo desee.",
            ["fr"] = "Nous utilisons des cookies pour garantir les fonctionnalités de base du site Web et pour améliorer votre expérience en ligne. Pour chaque catégorie, vous pouvez choisir de vous inscrire ou de vous désinscrire quand vous le souhaitez."
        };

        /// <summary>
        /// "Save preferences" text inside the settings modal.
        /// </summary>
        public Dictionary<string, string> SettingsContinueWithSelectedPreferencesText { get; set; } = new()
        {
            ["en"] = "Save preferences",
            ["de"] = "Präferenzen anwenden",
            ["nl"] = "Voorkeuren opslaan",
            ["es"] = "Guardar preferencias",
            ["fr"] = "Sauvegarder mes préférences"
        };

        /// <summary>
        /// Header line "Used services" to further detail which services are affected by a specific category.
        /// </summary>
        public Dictionary<string, string> SettingsUsedServicesText { get; set; } = new()
        {
            ["en"] = "Used services",
            ["de"] = "Verwendete Dienste",
            ["nl"] = "Gebruikte diensten",
            ["es"] = "Servicios utilizados",
            ["fr"] = "Services utilisés"
        };

        /// <summary>
        /// "Show cookie policy" text. Used in multiple places.
        /// </summary>
        public Dictionary<string, string> ShowPolicyText { get; set; } = new()
        {
            ["en"] = "Show cookie policy",
            ["de"] = "Cookie-Richtline anzeigen",
            ["nl"] = "Toon cookie beleid",
            ["es"] = "Abrir la poliza de cookies",
            ["fr"] = "Afficher la politique des cookies"
        };

        /// <summary>
        /// Available cookie categories. This by default only contains a "necessary" category.
        /// </summary>
        public List<CookieCategory> Categories { get; set; } = new()
        {
            new CookieCategory()
            {
                Identifier = CookieCategory.NecessaryCategoryIdentifier,
                TitleText = new()
                {
                    ["en"] = "Strictly necessary cookies",
                    ["de"] = "Umbedingt notwendige Cookies",
                    ["nl"] = "Strict noodzakelijke cookies",
                    ["es"] = "Cookies estrictamente necesarias",
                    ["fr"] = "Cookies strictement nécessaires"
                },
                DescriptionText = new()
                {
                    ["en"] = "These cookies are essential for the proper functioning of this website. They do not contain personal data and are not used to track you.",
                    ["de"] = "Diese Cookies sind umbedingt notwendig für die Nutzung dieser Webseite. Sie enthalten keine personenbezogenen Daten und werden nicht für Tracking verwendet.",
                    ["nl"] = "Deze cookies zijn essentieel voor het goed functioneren van deze website. Ze bevatten geen persoonlijke gegevens en worden niet gebruikt om u te volgen.",
                    ["es"] = "Estas cookies son esenciales para el correcto funcionamiento de este sitio web. No contienen datos personales y no se utilizan para rastrearlo.",
                    ["fr"] = "Ces cookies sont indispensables au bon fonctionnement de ce site. Ils ne contiennent pas de données personnelles et ne sont pas utilisés pour vous suivre."

                },
                IsRequired = true
            }
        };
    }

    public class CookieConsentCheckOptions
    {
        /// <summary>
        /// Text that describes why the content cannot be displayed.
        /// </summary>
        public Dictionary<string, string> Text { get; set; } = new()
        {
            ["en"] = "This content uses cookies that are disallowed by your settings. To show it, we need to adjust your cookie settings for our website. We require your consent for:",
            ["de"] = "Dieser Inhalt nutzt Cookies, die aktuell nicht erlaubt sind. Um ihn anzuzeigen, müssen Sie Ihre Cookie-Präferenzen auf unserer Webseite aktualisieren. Wir benötigen Ihre Zustimmung für:",
            ["nl"] = "Deze inhoud maakt gebruik van cookies die niet zijn toegestaan door uw instellingen. Om het te tonen, moeten we uw cookie-instellingen voor onze website aanpassen. Wij hebben uw toestemming nodig voor:",
            ["es"] = "Este contenido utiliza cookies que no están permitidas por su configuración. Para mostrarlo, necesitamos ajustar la configuración de cookies para nuestro sitio web. Requerimos su consentimiento para:",
            ["fr"] = "Ce contenu utilise des cookies qui sont interdits par vos paramètres.Pour l'afficher, nous devons ajuster vos paramètres de cookies pour notre site Web. Nous avons besoin de votre consentement pour :"
        };

        /// <summary>
        /// "Accept" text.
        /// </summary>
        public Dictionary<string, string> AcceptText { get; set; } = new()
        {
            ["en"] = "Accept",
            ["de"] = "Akzeptieren",
            ["nl"] = "Accepteren",
            ["es"] = "Aceptar",
            ["fr"] = "Accepter"
        };
    }

    public class CookieConsentCookieOptions
    {
        public string CookieName { get; set; } = ".AspNet.CookieConsent";
        public string CookieDomain { get; set; }
        public bool CookieHttpOnly { get; set; } = false;
        public bool CookieIsEssential { get; set; } = true;
        public TimeSpan? CookieMaxAge { get; set; } = TimeSpan.FromDays(180);
        public DateTime? CookieExpires { get; set; }
        public string CookiePath { get; set; } = "/";
        public string CookieSameSite { get; set; } = "Lax";
        public bool CookieSecure { get; set; } = true;
    }

    public class CookieCategory
    {
        /// <summary>
        /// Identifier of the category. This identifier gets references in multiple places throughout the library. Can be any custom value.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Title of the category.
        /// </summary>
        public Dictionary<string, string> TitleText { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Description of the category.
        /// </summary>
        public Dictionary<string, string> DescriptionText { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// List of services that are included in this category. Not mandatory.
        /// </summary>
        public List<CookieCategoryService> Services { get; set; } = new List<CookieCategoryService>();

        /// <summary>
        /// If true, this category is mandatory and cannot be disabled by the user.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// If true, this category will be preselected as enabled when the user opens the preferences and has not allowed/disallowed this category manually.
        /// </summary>
        public bool IsPreselected { get; set; }

        /// <summary>
        /// Predefined category identifier for the default necessary cookie category.
        /// </summary>
        public const string NecessaryCategoryIdentifier = "necessary";
    }

    public class CookieCategoryService
    {
        /// <summary>
        /// Identifier of the service. Can be any custom value.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// URL to this service's privacy policy.
        /// </summary>
        public string PolicyUrl { get; set; }

        /// <summary>
        /// Title of the service.
        /// </summary>
        public Dictionary<string, string> TitleText { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Text on the "Show policy" button next to the service name.
        /// </summary>
        public Dictionary<string, string> ShowPolicyText { get; set; } = new Dictionary<string, string>();

    }

    public enum ConsentModalPosition
    {
        TopLeft, TopCenter, TopRight,
        BottomLeft, BottomCenter, BottomRight
    }

    public enum ConsentModalLayout
    {
        Bar, Cloud
    }
}
