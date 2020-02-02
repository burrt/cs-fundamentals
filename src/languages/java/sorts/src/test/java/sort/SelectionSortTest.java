package sort;

import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import static org.hamcrest.CoreMatchers.is;
import static org.junit.Assert.*;
import static org.junit.Assert.assertTrue;

public class SelectionSortTest {
    private final SelectionSort selectionSort;

    public SelectionSortTest() {
        this.selectionSort = new SelectionSort();
    }

    @Test(expected = NullPointerException.class)
    public void sort_nullListOfUnsortedNumbers_throws() {
        this.selectionSort.sort(null);
    }

    @Test
    public void sort_emptyListNoCost_success() {
        // Act
        List<Integer> sorted = this.selectionSort.sort(new ArrayList<Integer>());

        // Assert
        assertTrue(sorted.isEmpty());
        assertEquals(0, this.selectionSort.getComparisons());
        assertEquals(0, this.selectionSort.getSwaps());
    }

    @Test
    public void sort_positiveNumbers_success() {
        // Arrange
        List<Integer> unsortedNumbers = Arrays.asList(14, 45, 96, 42, 32, 19, 18, 5, 30, 2, 99, 61, 20, 53, 100, 33, 10, 7, 57, 23, 24, 38, 9, 78, 74, 83, 59, 39, 82, 85);
        List<Integer> expectedSortedNumbers = Arrays.asList(2, 5, 7, 9, 10, 14, 18, 19, 20, 23, 24, 30, 32, 33, 38, 39, 42, 45, 53, 57, 59, 61, 74, 78, 82, 83, 85, 96, 99, 100);

        // Act
        List<Integer> sorted = this.selectionSort.sort(unsortedNumbers);

        // Assert
        assertThat(sorted, is(expectedSortedNumbers));
        assertTrue(this.selectionSort.getComparisons() > 0);
        assertTrue(this.selectionSort.getSwaps() > 0);
    }

    @Test
    public void sort_negativeNumbers_success() {
        // Arrange
        List<Integer> unsortedNumbers = Arrays.asList(-80, -83, -13, -61, -14, -99, -34, -84, -10, -92, -91, -23, -62, -43, -87, -16, -57, -22, -73, -93, -89, -24, -75, -55, -76, -86, -46, -20, -18, -36);
        List<Integer> expectedSortedNumbers = Arrays.asList(-99, -93, -92, -91, -89, -87, -86, -84, -83, -80, -76, -75, -73, -62, -61, -57, -55, -46, -43, -36, -34, -24, -23, -22, -20, -18, -16, -14, -13, -10);

        // Act
        List<Integer> sorted = this.selectionSort.sort(unsortedNumbers);

        // Assert
        assertThat(sorted, is(expectedSortedNumbers));
        assertTrue(this.selectionSort.getComparisons() > 0);
        assertTrue(this.selectionSort.getSwaps() > 0);
    }

    @Test
    public void sort_negativeAndPositiveNumbers_success() {
        // Arrange
        List<Integer> unsortedNumbers = Arrays.asList(49, 28, 13, 43, 36, -9, 48, -20, -38, 31, 18, -8, 27, 11, 23, -34, -15, 1, -16, -6, -30, -48, 26, 47, -50, -41, -3, 12, 34, 41);
        List<Integer> expectedSortedNumbers = Arrays.asList(-50, -48, -41, -38, -34, -30, -20, -16, -15, -9, -8, -6, -3, 1, 11, 12, 13, 18, 23, 26, 27, 28, 31, 34, 36, 41, 43, 47, 48, 49);

        // Act
        List<Integer> sorted = this.selectionSort.sort(unsortedNumbers);

        // Assert
        assertThat(sorted, is(expectedSortedNumbers));
        assertTrue(this.selectionSort.getComparisons() > 0);
        assertTrue(this.selectionSort.getSwaps() > 0);
    }
}
