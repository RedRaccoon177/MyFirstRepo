using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Project_Assignment
{
    class Inventory
    {
        Item[] items;

        //첫번째 메서드
        public void CreateInvenBySize(int size)
        {
            items = new Item[size];
        }

        //두번째 메서드
        public bool isInvenCreated()
        {
            bool invenCr;
            if (items.Length < 0 || items == null)
            {
                invenCr = false;
            }
            else
            {
                invenCr = true;
            }
            return invenCr;
        }

        //세번째 메서드
        public Item GetItemByIndex(int itemExist)
        {
            if (items.Length < itemExist)
            {
                items[itemExist] = null;

                return items[itemExist];
            }
            else if (items.Length < 0)
            {
                items[itemExist] = null;

                return items[itemExist];
            }
            else
            {
                return items[itemExist];
            }
        }

        //네번째 메서드
        public void SetItemByIndex(Item item, int inputIndex)
        {
            items[inputIndex] = item;
        }

    }
}
