package sort;

import cost.Cost;
import sort.util.SwapUtil;

import java.util.ArrayList;
import java.util.List;

public class BubbleSort implements Sort, Cost {
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
            int innerSwaps = 0;
            for (int j = 0; j < sorted.size()-1; j++) {
                if (sorted.get(j+1) < sorted.get(j)) {
                    SwapUtil.swap(sorted, j, j+1);
                    this.swaps++;
                    innerSwaps++;
                }
                this.comps++;
            }

            if (innerSwaps == 0) {
                break;
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
