#define NULL 0
int*** create_3d_array_linear(int rows, int cols, int depth) {
    int total_elements = rows * cols * depth;
    int*** array = (int***)malloc(rows * sizeof(int**));
    if (!array) return NULL;
    for (int i = 0; i < rows; i++) {
        array[i] = (int**)malloc(cols * sizeof(int*));
        if (!array[i]) {
            for (int j = 0; j < i; j++) {
               free(array[j]);
            }
            free(array);
            return NULL;
        }
    }
    int* linear_array = (int*)malloc(total_elements * sizeof(int));
    if (!linear_array) {
        for (int i = 0; i < rows; i++) {
            free(array[i]);
        }
        free(array);
        return NULL;
    }
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            array[i][j] = &linear_array[(i * cols) + j];
        }
    }
    return array;
}

void destroy_3d_array_linear(int*** array, int rows, int cols) {
    free(array);[0][0][0]
;}