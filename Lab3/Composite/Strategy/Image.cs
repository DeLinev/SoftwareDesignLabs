using System.Text;

namespace Composite.Strategy
{
    public class Image : LightElementNode
    {
        public string Href
        {
            get => _href;
            set
            {
                _href = value;

                if (_href.StartsWith("http://") || _href.StartsWith("https://"))
                {
                    SetImageLoader(new NetworkLoader());
                }
                else
                {
                    SetImageLoader(new FileSystemLoader());
                }

                SetAttribute("src", _href);
                RemoveAttribute("alt");
            }
        }
        private string _href;
        private IImageLoader? imageLoader;

        public Image(string href) : base("img", false, true)
        {
            Href = href;
        }

        public void SetImageLoader(IImageLoader loader)
        {
            imageLoader = loader;
        }

        public void LoadImage()
        {
            if (imageLoader != null)
            {
                string result  = imageLoader.LoadImage(Href);
                SetAttribute("alt", result);
            }
        }
    }
}
