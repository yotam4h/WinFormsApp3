using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Backend.Models;

namespace WinFormsApp3.Backend
{
    public class MenuManager
    {
        private static BindingList<MenuItem> menuItems;

        static MenuManager()
        {
            menuItems = new BindingList<MenuItem>();
        }

        public static void AddMenuItem(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

        public static void RemoveMenuItem(MenuItem menuItem)
        {
            menuItems.Remove(menuItem);
        }

        public static BindingList<MenuItem> GetMenuItems()
        {
            return menuItems;
        }

        public static void SaveMenuItems()
        {
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            binaryFormatter.Serialize(stream, MenuManager.GetMenuItems());
            stream.Close();
        }

        public static void LoadMenuItems()
        {
            Stream stream = File.Open("MyFile.bin", FileMode.Open);
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            menuItems = (BindingList<MenuItem>)binaryFormatter.Deserialize(stream);
            stream.Close();
        }

        public static void ClearMenuItems()
        {
            menuItems.Clear();
        }

        public static BindingList<T> GetMenuItemsByChild<T>() where T : MenuItem
        {
            BindingList<T> child = new();
            foreach (MenuItem element in menuItems)
            {
                if (element is not T)
                {
                    continue;
                }
                child.Add((T)element);
            }
            return child;
        }
    }
}
