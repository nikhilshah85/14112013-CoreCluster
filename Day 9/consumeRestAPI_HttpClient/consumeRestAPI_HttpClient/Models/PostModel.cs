namespace consumeRestAPI_HttpClient.Models
{
    public class PostModel
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        private static List<PostModel> postModels = new List<PostModel>();

        public  List<PostModel> getPostModels()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear(); //every browser has a default dataformat,
                                                         //eg.chrome has XML, edge has JSON, some browsers on linux has text we need to clear them 


            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var callDetails =client.GetAsync(url).Result;

            List<PostModel> data = new List<PostModel>(); //this is where we will collect the data and return the data

            //if call is successful or failed

            if (callDetails.IsSuccessStatusCode)
            {
                 var result =  callDetails.Content.ReadAsAsync<List<PostModel>>();
                 //wait to complete data to be read
                 result.Wait();
                data = result.Result;
                
                return data;                             

            }
            else
            {
                throw new Exception("Sorry could not get the data, please contact admin");
            }











        }
    }
}
