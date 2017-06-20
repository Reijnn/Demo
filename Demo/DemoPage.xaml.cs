using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Demo
{
    public partial class DemoPage : ContentPage
    {
        private TrelloItem item { get; set; } = null;
        public DemoPage()
        {
            InitializeComponent();
        }

		private async Task<bool> getTrelloItem()
		{
			try
			{
				var json =
					await new HttpClient().GetStringAsync(
						"https://api.trello.com/1/board/XUb9AMvz?key=ca4fcd3f80ad1dc2ff1667549030fe15&cards=open&lists=open");
				item = JsonConvert.DeserializeObject<TrelloItem>(json);
			}
			catch (Exception ex)
			{
				await DisplayAlert("Error", ex.Message, "Ok");
				return false;
			}
			return true;
		}

		private async void BGetCards_OnClicked(object sender, EventArgs e)
		{
			bGetCards.IsEnabled = false;
			if (await getTrelloItem()) lvCards.ItemsSource = item.cards;
			bGetCards.IsEnabled = true;
		}
    }
}
