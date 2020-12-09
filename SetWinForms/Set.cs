using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Set
{
    //Множество
    class Set<T> : IEnumerable
    {
        //Коллекция хранимых данных
        private List<T> items = new List<T>();

        //Количество элементов
        public int Count => items.Count;

        //Пустой конструктор
        public Set() { }

        //Конструктор с добавлением одного элемента в множество
        public Set(T item)
        {
            items.Add(item);
        }

        //Конструктор с добавлением элементов в множество с помощью перебора коллекции>
        public Set(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        //Операция добавления элемента в множество
        public void Add(T item)
        {
            if (Count >= 2000)
            {
                throw new Exception("Слишком много элементов добавлено в множество, по заданию 2000 - максимум (хотя можно было и больше :) )");
            }
            // Проверяем есть ли такой элемент в нашем множестве
            if (items.Contains(item))
            {
                // Если есть, прерываем
                return;
            }
            // Если нет, добавляем
            items.Add(item);
        }

        //Операция удаления элемента из множества
        public void Remove(T item)
        {
            items.Remove(item);
        }

        //Операция объединения двух множеств
        public Set<T> Union(Set<T> set)
        {
            // Результирующее множество
            Set<T> result = new Set<T>();

            // Добавляем все элементы из первого множества в результирующее
            foreach (T item in items)
            {
                result.Add(item);
            }
            // Добавляем все элементы из второго множества в результирующее
            foreach (T item in set.items)
            {
                result.Add(item);
            }
            // Возвращаем результирующее множество
            return result;
        }

        //Операция пересечения множеств
        public Set<T> Intersection(Set<T> set)
        {
            // Результирующее множество
            Set<T> result = new Set<T>();
            // Большее множество
            Set<T> big = new Set<T>();
            // Меньшее множество
            Set<T> small = new Set<T>();

            // Узнаем какое множество больше
            if (Count > set.Count)
            {
                big = this;
                small = set;
            }
            else
            {
                big = set;
                small = this;
            }
            // Берем элемент из большего множества
            foreach (T item1 in small.items)
            {
                // Берем элементы из меньшего множества
                foreach (T item2 in big.items)
                {
                    // Сравниваем все элементы меньшего с элементом большего
                    if (item1.Equals(item2))
                    {
                        // Если совпали, добавляем в результирующее множество
                        result.Add(item1);
                        break;
                    }
                }
            }

            return result;
        }

        //Операция разности двух множеств
        public Set<T> Difference(Set<T> set)
        {
            // Результирующее множество
            Set<T> result = new Set<T>(items);

            //Берем все элементы из второго множества
            foreach (T item in set.items)
            {
                // Удаляем эти элементы из первого множества
                result.Remove(item);
            }

            return result;
        }

        //Операция проверки на подмножество
        public bool SubSet(Set<T> set)
        {
            // Берем элемент множества
            foreach (T item1 in set.items)
            {
                bool equals = false;
                // Берем все элементы множества
                foreach (T item2 in items)
                {
                    // Если эл-т подмножества совпал хотя бы с одним эл-том множества
                    if (item1.Equals(item2))
                    {
                        // Закончить проверку
                        equals = true;
                        break;
                    }

                }
                // Если эл-т подмножества не совпал ни с одним эл-том множества
                if (!equals)
                {
                    // Вернуть false
                    return false;
                }
            }

            return true;
        }

        //Операция симетричной разности двух множеств
        public Set<T> SymmetricDifference(Set<T> set)
        {
            return this.Difference(set).Union(set.Difference(this));
        }

        // Реализация GetEnumerator из интерфейса IEnumerator
        // Для возможности вызова foreach
        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
