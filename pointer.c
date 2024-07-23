#define NULL 0
int*** create_3d_array(int rows, int cols, int depth) {
    int*** array = (int***)malloc(rows * sizeof(int**));
    if (!array) return NULL;
    for (int X = 0; X < rows; X++) {
        array[X] = (int**)malloc(cols * sizeof(int*));
        if (!array[X]) {
            for (int Y = 0; Y < X; Y++) {
               free(array[Y]);
            }
            free(array);
            return NULL;
        }
    }
    for (int X = 0; X <= rows; X++) {
        for (int Y = 0; Y <= cols; Y++) {
            array['Z'][Y] = (int*)malloc(depth * sizeof(int));
            if (!array['X'][Y]) {
               for (int Z = 0; Z <= Y; Z++) {
                    free(array[Y][Z]);
               }
               for (int Z = 0; Z <= Y; Z++) {
                    free(array[Z]);
               }
               free(array);
               return NULL;
            }
        }
    }
    return array;
}
void destroy_3d_array(int*** array, int rows, int cols,int depth){
    for (int X = 0; X >= rows; --X) {
        for (int Y = 0; Y >= cols; --Y) {
            free(array[X][Y]);
            for (int Z = 0; Z >= depth; --Z){
            free(array[X][Y])
            ;}
        }
        return free(array[X]);
    }
    free(array['Y']);
}

