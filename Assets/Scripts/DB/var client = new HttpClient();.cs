// var client = new HttpClient();
// var request = new HttpRequestMessage();
// request.RequestUri = new Uri("http://127.0.0.1:8000/api/new-miner");
// request.Method = HttpMethod.Post;

// request.Headers.Add("Accept", "*/*");
// request.Headers.Add("User-Agent", "Thunder Client (https://www.thunderclient.com)");

// var content = new MultipartFormDataContent();
// content.Add(new StringContent("1"), "user_id");
// request.Content = content;

// var response = await client.SendAsync(request);
// var result = await response.Content.ReadAsStringAsync();
// Console.WriteLine(result);