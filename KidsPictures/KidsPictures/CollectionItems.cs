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
                    ImageItem = new Image{Source = "owl.jpg"}
                },
                new CollectionItems {
                    NameItem = "ОЛЕНЬ",
                    ImageItem = new Image{Source = "deer.jpg"}
                },
                new CollectionItems {
                    NameItem = "СУРОК",
                    ImageItem = new Image{Source = "marmot.jpg"}
                },
                new CollectionItems {
                    NameItem = "СОБАКА",
                    ImageItem = new Image{Source = "dog.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "КРОЛЬ",
                    ImageItem = new Image{Source = "rabbit.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "ВОЛК",
                    ImageItem = new Image{Source = "wolf.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "КОЗЕЛ",
                    ImageItem = new Image{Source = "goat.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "МЕДВЕДЬ",
                    ImageItem = new Image{Source = "beer.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "ЛИСА",
                    ImageItem = new Image{Source = "fox.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "КОШКА",
                    ImageItem = new Image{Source = "cat.jpg"}
                },
                new CollectionItems
                {
                    NameItem = "ЛЕВ",
                    ImageItem = new Image{Source = "lion.jpg"}
                },
            };
        }
    }
}
