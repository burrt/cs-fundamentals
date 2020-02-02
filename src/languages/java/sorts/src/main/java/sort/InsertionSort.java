package sort;

import cost.Cost;
import sort.util.SwapUtil;

import java.util.ArrayList;
import java.util.List;

public class InsertionSort implements Sort, Cost {
    private int swaps;
    private int comps;

    /**
     * {@inheritDoc}
     */
    @Override
    public List<Integer> sort(List<Integer> unsortedNumbers) {
        if (unsortedNumbers == null) {
            throw new NullPointerException("unsortedNumbers");
        }

        List<Integer> sorted = new ArrayList<>(unsortedNumbers);
        for (int i = 1; i < sorted.size(); i++) {
            for (int j = i; j > 0; j--) {
                if (sorted.get(j) < sorted.get(j-1)) {
                    SwapUtil.swap(sorted, j, j-1);
                    this.swaps++;
                }
                this.comps++;
            }
        }

        return sorted;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public int getSwaps() {
        return this.swaps;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public int getComparisons() {
        return this.comps;
    }
}
