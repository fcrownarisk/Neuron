#define NULL 0
int*** create_3d_array(int rows, int cols, int depth) {
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
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            array[i][j] = (int*)malloc(depth * sizeof(int));
            if (!array[i][j]) {
               for (int k = 0; k < j; k++) {
                    free(array[i][k]);
               }
               for (int k = 0; k < i; k++) {
                    free(array[k]);
               }
               free(array);
               return NULL;
            }
        }
    }
    return array;
}

void destroy_3d_array(int*** array, int rows, int cols) {
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            free(array[i][j]);
        }
        free(array[i]);
    }
    free(array);
}