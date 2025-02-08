using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ADV_03.Part03
{
    public static class ListMehods
    {
        #region Exist

        public static bool ScratchExist<T>(this List<T> list , Predicate<T> predicate )
        {
            if (list is null || predicate is null)
            {
                return false;
            }
            bool flag = false;

            foreach (var item in list)
            {
                if (predicate(item))
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        #endregion

        #region Find

        // Find -> search for the first element that satisfies the condition

        public static T ScratchFind<T>(this List<T> list, Predicate<T> predicate)
        {
            if (list is null || predicate is null)
            {
                return default(T)!;
            }

            foreach (var item in list)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default(T)!;
        }

        #endregion

        #region FindAll

        // FindAll -> search for all elements that satisfy the condition

        public static List<T> ScratchFindAll<T>(this List<T> list, Predicate<T> predicate)
        {
            if (list is null || predicate is null)
            {
                return new List<T>();
            }

            List<T> result = new List<T>();

            foreach (var item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        #endregion

        #region FindIndex

        // FindIndex -> search for the index of the first element that satisfies the condition

        public static int ScratchFindIndex<T>(this List<T> list, Predicate<T> predicate)
        {
            if (list is null || predicate is null)
            {
                return -1;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        #endregion

        #region FindLast

        // FindLast -> search for the last element that satisfies the condition

        public static T ScratchFindLast<T>(this List<T> list, Predicate<T> predicate)
        {
            if (list is null || predicate is null)
            {
                return default(T)!;
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i]))
                {
                    return list[i];
                }
            }

            return default(T)!;
        }

        #endregion

        #region FindLastIndex

        // FindLastIndex -> search for the index of the last element that satisfies the condition

        public static int ScratchFindLastIndex<T>(this List<T> list, Predicate<T> predicate)
        {
            if (list is null || predicate is null)
            {
                return -1;
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        #endregion

        #region ForEach

        // ForEach -> execute a specific action for each element in the list

        public static void ScratchForEach<T>(this List<T> list, Action<T> action)
        {
            if (list is null || action is null)
            {
                return;
            }

            foreach (var item in list)
            {
                action(item);
            }
        }

        #endregion

        #region TrueForAll

        // TrueForAll -> check if all elements satisfy the condition

        public static bool ScratchTrueForAll<T>(this List<T> list, Predicate<T> predicate)
        {
            if (list is null || predicate is null)
            {
                return false;
            }

            foreach (var item in list)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
