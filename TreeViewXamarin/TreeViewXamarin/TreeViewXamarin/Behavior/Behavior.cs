using Syncfusion.XForms.TreeView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin
{
    public class Behavior : Behavior<ContentPage>
    {
        Syncfusion.XForms.TreeView.SfTreeView treeView;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            treeView = bindable.FindByName<SfTreeView>("treeView");
            treeView.ItemDoubleTapped += TreeView_ItemDoubleTapped;
        }
        private void TreeView_ItemDoubleTapped(object sender, ItemDoubleTappedEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Item DoubleTapped", "TreeView item double tapped", "Close");
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            treeView.ItemDoubleTapped += TreeView_ItemDoubleTapped;
        }
    }
}
        
    

