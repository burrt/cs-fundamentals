package sort;

import java.util.List;

/**
 * Interface for sorting objects.
 */
public interface Sort {

    /**
     * Sorts the list of numbers.
     * @param unsortedNumbers the list to sort
     * @return sorted numbers list
     */
    public List<Integer> sort(List<Integer> unsortedNumbers);
}
