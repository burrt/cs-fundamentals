package sort.util;

import java.util.List;

public final class SwapUtil {

    /**
     * Swaps the two elements in a list.
     * @param list list to swap elements
     * @param i first element to swap
     * @param j second element to swap
     */
    public static void swap(List<Integer> list, int i, int j) {
        int temp = list.get(j);
        list.set(j, list.get(i));
        list.set(i, temp);
    }
}
