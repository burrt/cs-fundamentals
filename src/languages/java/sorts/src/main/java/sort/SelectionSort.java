package sort;

import cost.Cost;
import sort.util.SwapUtil;

import java.util.ArrayList;
import java.util.List;

public class SelectionSort implements Sort, Cost {
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

        for (int i = 0; i < sorted.size(); i++) {
            int minIndex = i;
            for (int j = i+1; j < sorted.size(); j++) {
                if (sorted.get(j) < sorted.get(minIndex)) {
                    minIndex = j;
                }
                this.comps++;
            }
            if (i != minIndex) {
                SwapUtil.swap(sorted, i, minIndex);
                this.swaps++;
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
