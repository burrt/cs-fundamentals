package cost;

/**
 * Interface for cost operations of a sort algorithm.
 */
public interface Cost {

    /**
     * Get the number of swaps the sort has made.
     * @return the number of swap operations
     */
    public int getSwaps();

    /**
     * Get the number of comparisons the sort has made.
     * @return the number of comparison operations
     */
    public int getComparisons();
}
