using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DynamicEditor.ViewModel;
using DynamicEditor.Model;

namespace DynamicEditor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        MesssageVideModel vm = null;

        public ListViewPage()
        {
            InitializeComponent();

            vm = new MesssageVideModel();
            //this.BindingContext = vm;
            if (vm.Messages == null)
            {
                vm.Messages = new ObservableCollection<MessageModel>();
            }
            int i = 0;
            for (i = 1; i <= 20; i++)
            {
                vm.Messages.Add(new MessageModel()
                {
                    ID = i,
                    Message = string.Format("Test Message xxxxxx {0}", i),
                    Image = "User.png"
                });
            }
            MyListView.ItemsSource = vm.Messages;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            ((ListView)sender).SelectedItem = null;
        }
    }
}
