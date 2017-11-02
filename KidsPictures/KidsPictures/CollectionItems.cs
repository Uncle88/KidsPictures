using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace KidsPictures
{
    public class CollectionItems
    {
        public string NameItem { get; set; }
        public string ImageItem { get; set; }

        public static IList<CollectionItems> All { get; set; }

        static CollectionItems()
        {
            All = new ObservableCollection<CollectionItems> {
                new CollectionItems {
                    NameItem = "СОВА",
                    ImageItem =  "owl.jpg"
                },
                new CollectionItems {
                    NameItem = "ОЛЕНЬ",
                    ImageItem = "deer.jpg"
                },
                new CollectionItems {
                    NameItem = "СУРОК",
                    ImageItem = "marmot.jpg"
                },
                new CollectionItems {
                    NameItem = "СОБАКА",
                    ImageItem =  "dog.jpg"
                },
                new CollectionItems
                {
                    NameItem = "КРОЛЬ",
                    ImageItem = "rabbit.jpg"
                },
                new CollectionItems
                {
                    NameItem = "ВОЛК",
                    ImageItem =  "wolf.jpg"
                },
                new CollectionItems
                {
                    NameItem = "КОЗЕЛ",
                    ImageItem = "goat.jpg"
                },
                new CollectionItems
                {
                    NameItem = "МЕДВЕДЬ",
                    ImageItem = "bear.jpg"
                },
                new CollectionItems
                {
                    NameItem = "ЛИСА",
                    ImageItem = "fox.jpg"
                },
                new CollectionItems
                {
                    NameItem = "КОШКА",
                    ImageItem = "cat.jpg"
                },
                new CollectionItems
                {
                    NameItem = "ЛЕВ",
                    ImageItem =  "lion.jpg"
                },
            };
        }
    }
}
