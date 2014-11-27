namespace TestingFramework.Core.Base
{
    using ArtOfTest.WebAii.Core;

    public abstract class BasePage<TMap, TValidator>
        where TMap : BaseElementMap, new() 
        where TValidator : new()
    {
        private TMap map;
        private TValidator validator;
        
        public TMap Map
        {
            get
            {
                if (map == null)
                {
                    map = new TMap();
                }
                return map;
            }
        }

        public TValidator Validator
        {
            get
            {
                if (validator == null)
                {
                    validator = new TValidator();
                }
                return validator;
            }
        }

        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        public abstract string Url { get; }

        public virtual void Navigate()
        {
            if (Browser.Url != Url)
            {
                Browser.NavigateTo(Url);
            }
        }
    }
}
