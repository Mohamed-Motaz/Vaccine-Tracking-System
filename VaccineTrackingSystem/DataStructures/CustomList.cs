using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineTrackingSystem.DataModels;

namespace VaccineTrackingSystem.DataStructures
{
	class CustomList<T> : IEnumerable<T>, IEnumerator   //IEnumerable<T>, IEnumerator To be able to use with foreach loop and get the iterator using function
	{
		private T []arr;
		private int size;
		public int CurrentPos = -1;   //index used
		public int position = -1;
        private bool disposedValue;

        public T this[int index]    
		{
			get { return arr[index]; } //allows CustomList[0] instead of CustomList.arr[0]; 
			set { arr[index] = value; } //allows CustomList[0] = 0 instead of CustomList.arr[0] = 0; 
		}
		public CustomList()
		{
			arr = new T[105];
			size = 105;
		}

		public bool MoveNext()  //Mandatory
		{
			position++;
			return (position <= CurrentPos);
		}
		public void Reset()  //Mandatory
		{
			position = 0;
		}
		public object Current  //Mandatory
		{
			get { return arr[position]; }
		}


        public void Expand()
		{
			int NewSize = size + 60;
			T[] NewArr = new T[NewSize];
			for (int i = 0; i < size; i++)
				NewArr[i] = arr[i];
				
			arr = NewArr;
			size = NewSize;
		}
		public void Add(T value)
		{
			CurrentPos++;
			if(CurrentPos == size)
			{
				Expand();
			}
			arr[CurrentPos] = value;
		}

		private void Delete(int index)
		{
			if (index > CurrentPos || index < 0) return;
			for (int i = index; i < CurrentPos; i++)
				arr[i] = arr[i + 1];
			arr[CurrentPos] = default(T);
			CurrentPos--;
		}
		public void Clear()
		{
			for (int i = 0; i <= CurrentPos; i++)   //only reason is to remove objects from the memory
				arr[i] = default(T);
			CurrentPos = -1;
		}
		public void Remove(T obj)
		{
			int idx = -1;
			for (int i = 0; i <= CurrentPos; i++)
				if (Object.ReferenceEquals(arr[i],obj))
					idx = i;
			if (idx == -1) return;
			Delete(idx);

		}
		public IEnumerator<T> GetEnumerator()  //Mandatory
		{
			foreach (T o in arr)
			{
				if (o == null)
					break;
				yield return o;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()  //Mmandatory
		{
			return this.GetEnumerator();
		}

        
    }
}