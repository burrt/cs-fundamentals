import pytest
import random
from sorts import Sorter

Sorter = Sorter()
correct_sorted_positive_numbers = list(range(0, 30))

class TestBoundaries:
    test_data = [
        ([], []),
        ([0], [0]),
        ([-1], [-1]),
        ([None], [None]),
    ]

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_bubble_sort_with(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.bubble_sort(sorted_numbers)

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_insertion_sort(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.insertion_sort(sorted_numbers)

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_selection_sort(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.selection_sort(sorted_numbers)

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_merge_sort(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.merge_sort(sorted_numbers)

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_quick_sort_hoare_partition(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.quick_sort(sorted_numbers, 0, len(sorted_numbers)-1, "quick_h")

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_quick_sort_lomuto_partition(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.quick_sort(sorted_numbers, 0, len(sorted_numbers)-1, "quick_l")

        assert sorted_numbers == expected


class TestValidNumbers:
    test_data = [
        ([-32, 14, 55, -41, 28, 20, 31, 36, 6, 78, 12, 14, 27, -34, 63], [-41, -34, -32, 6, 12, 14, 14, 20, 27, 28, 31, 36, 55, 63, 78]),
        ([14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0], [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]),
        ([1, 1, 1, 1, 1, 1, 1, 1, 1, 1], [1, 1, 1, 1, 1, 1, 1, 1, 1, 1]),
    ]

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_bubble_sort_with(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.bubble_sort(sorted_numbers)

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_insertion_sort(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.insertion_sort(sorted_numbers)

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_selection_sort(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.selection_sort(sorted_numbers)

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_merge_sort(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.merge_sort(sorted_numbers)

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_quick_sort_hoare_partition(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.quick_sort(sorted_numbers, 0, len(sorted_numbers)-1, "quick_h")

        assert sorted_numbers == expected

    @pytest.mark.parametrize("testdata,expected", test_data)
    def test_quick_sort_lomuto_partition(self, testdata, expected):
        sorted_numbers = list(testdata)

        Sorter.quick_sort(sorted_numbers, 0, len(sorted_numbers)-1, "quick_l")

        assert sorted_numbers == expected
