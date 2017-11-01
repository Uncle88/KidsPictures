using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace KidsPictures
{
    public class CollectionItems
    {
        public string NameItem { get; set; }
        public Image ImageItem { get; set; }

        public static IList<CollectionItems> All { get; set; }

        static CollectionItems()
        {
            All = new ObservableCollection<CollectionItems> {
                new CollectionItems {
                    NameItem = "СОВА",
                    ImageItem = new Image{Source = "Animal1.jpg"}
                },
                new CollectionItems {
                    NameItem = "ОЛЕНЬ",
                    ImageItem = new Image{Source = "Animal2.jpg"}
                },
                new CollectionItems {
                    NameItem = "СУРОК",
                    ImageItem = new Image{Source = "Animal3.jpg"}
                },
                new CollectionItems {
                    NameItem = "СОБАКА",
                    ImageItem = new Image{Source = "Animal4.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "КРОЛЬ",
                    ImageItem = new Image{Source = "Animal5.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "ВОЛК",
                    ImageItem = new Image{Source = "Animal6.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "КОЗЕЛ",
                    ImageItem = new Image{Source = "Animal7.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "МЕДВЕДЬ",
                    ImageItem = new Image{Source = "Animal8.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "ЛИСА",
                    ImageItem = new Image{Source = "Animal9.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "КОШКА",
                    ImageItem = new Image{Source = "Animal10.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "ЛЕВ",
                    ImageItem = new Image{Source = "Animal11.jpg"}
                },
            };
        }
    }
}
