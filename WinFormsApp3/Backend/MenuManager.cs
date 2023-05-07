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

        public static void SaveMenuItems(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        public static void RestoreMenuItems()
        {
            throw new NotImplementedException();
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
