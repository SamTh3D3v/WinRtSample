using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App9
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

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            SearchFolder();
        }
        async void SearchFolder()
        {
          
            var query = ApplicationData.Current.LocalFolder.CreateFileQuery();
            query.ContentsChanged += QueryContentsChanged;           
            
            var files = await query.GetFilesAsync();
            
        }
        void QueryContentsChanged(Windows.Storage.Search.IStorageQueryResultBase sender, object args)
        {
            throw new NotImplementedException();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ApplicationData.Current.LocalFolder.CreateFileAsync("newFile");
        }
    }
}
