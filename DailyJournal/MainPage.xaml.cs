using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DailyJournal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EntriesListView.Items.Add("super");
            EntriesListView.Items.Add("extra");
            EntriesListView.Items.Add("maximum");
            EntriesListView.Items.Add("advanced");
            EntriesListView.Items.Add("efficient");
            EntriesListView.Items.Add("2 super");
            EntriesListView.Items.Add("2 extra");
            EntriesListView.Items.Add("2 maximum");
            EntriesListView.Items.Add("2 advanced");
            EntriesListView.Items.Add("2 efficient");
        }

        private void CreateNewEntryButton_Click(object sender, RoutedEventArgs e)
        {
            TabViewItem newItem = new TabViewItem();
            var entryText = String.Format($"Entry{Tabs.TabItems.Count + 1}");
            newItem.Header = entryText;

            RichEditBox reb = new RichEditBox();
            reb.HorizontalAlignment = HorizontalAlignment.Stretch;
            reb.VerticalAlignment= VerticalAlignment.Stretch;
            newItem.Content = reb;
            Tabs.TabItems.Add(newItem);
            Tabs.SelectedIndex = Tabs.TabItems.Count - 1;
        }

        private void Tabs_AddTabButtonClick(TabView sender, object args)
        {
            TabViewItem newItem = new TabViewItem();
            var entryText = String.Format($"Entry{Tabs.TabItems.Count + 1}");
            newItem.Header = entryText;

            RichEditBox reb = new RichEditBox();
            reb.HorizontalAlignment = HorizontalAlignment.Stretch;
            reb.VerticalAlignment = VerticalAlignment.Stretch;
            newItem.Content = reb;
            Tabs.TabItems.Add(newItem);
            Tabs.SelectedIndex = Tabs.TabItems.Count - 1;
        }
    }
}
