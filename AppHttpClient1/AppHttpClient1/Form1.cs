using System.Net.Http;

namespace AppHttpClient1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async Task<string> GetDataAsync(string url)
        {
            // https://webscraping.ai/faq/httpclient-c/how-do-i-handle-exceptions-thrown-by-httpclient-c-methods
     
            string s = "";
            using (var httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                    else
                    {
                        s = await response.Content.ReadAsStringAsync();
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Request error: {e.Message}");
                }
                catch (TaskCanceledException e)
                {
                    if (e.CancellationToken.IsCancellationRequested)
                    {
                        MessageBox.Show("Request was canceled.");
                    }
                    else
                    {
                        MessageBox.Show("Request timed out.");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An error occurred: {e.Message}");
                }
            }
            return s;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("¬ведите адрес дл€ получени€ строки - пусто");
                return;
            }
            string s = "";
            s = await GetDataAsync(this.textBox1.Text);
            if (s == "")
            {
                MessageBox.Show("пуста§ строка - возможно сервер не запущен");
                return;
            }
            this.textBox2.Text = s;

        }



    }
}
