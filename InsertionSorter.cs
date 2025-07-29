namespace InsertionSorter
{
    public class InsertionSorter
    {
        public List<int> SortNumbers(List<int> unsortedList) {
            //For-Loop through the list and check:
            int current = 0;
            for(int i = 1; i < unsortedList.Count; i++) {
                //While will iterate through every subsequent element and carry out comparison
                current = i;
                
                while (current > 0 && unsortedList[current - 1] > unsortedList[current]) 
                {
                    int temp = unsortedList[current];

                    unsortedList[current] = unsortedList[current - 1];

                    unsortedList[current - 1] = temp;

                    current--;
                }
            }
            //Return the sorted list
            return unsortedList;//Now sorted :=)
        }
    }
}
