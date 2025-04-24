namespace Composite.Strategy
{
    public class NetworkLoader : IImageLoader
    {
        public string LoadImage(string href)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync(href).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return $"Image was loaded from network: {href}. Status code: {response.StatusCode}";
                    }

                    return $"Error: Couldn't load image from {href}. Status code: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"Error: Couldn't load image from {href}. Exception: {ex.Message}";
            }
        }
    }
}
