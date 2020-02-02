import sort.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.logging.*;
import java.util.List;
import java.util.ServiceLoader;

public class Sorts {
    private static final Logger logger = Logger.getLogger(Sorts.class.getName());
    private final List<Integer> unsortedNumbers;
    private final List<Sort> sorts;

    /**
     * Sorts constructor which instantiates all classes that implement Sort.
     * @param serviceLoader service loader of Sort
     * @throws IllegalAccessException illegal access exception
     * @throws InstantiationException instantiation exception
     */
    public Sorts(ServiceLoader<Sort> serviceLoader) throws IllegalAccessException, InstantiationException {
        this.unsortedNumbers = Arrays.asList(14, 45, 96, 42, 32, 19, 18, 5, 30, 2, 99, 61, 20, 53, 100, 33, 10, 7, 57, 23, 24, 38, 9, 78, 74, 83, 59, 39, 82, 85);

        // Initialize each sort
        this.sorts = new ArrayList<>();
        for (Sort sort : serviceLoader) {
            this.sorts.add(sort.getClass().newInstance());
        }
    }

    /**
     * Run all sorts.
     */
    public void runAll() {
        for (Sort sort : this.sorts) {
            logger.info("Sort: " + sort.getClass().toGenericString());

            List<Integer> sorted = sort.sort(this.unsortedNumbers);
            logger.info(sorted.toString());
        }
    }

    public static void main(String[] args) throws InstantiationException, IllegalAccessException {
        Sorts sorts = new Sorts(ServiceLoader.load(Sort.class));
        sorts.runAll();
    }
}
