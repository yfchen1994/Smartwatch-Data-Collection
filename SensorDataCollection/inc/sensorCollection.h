// Declearation of basic data structures

struct _sensor_data {
	double x;
	double y;
	double z;
};

typedef struct _sensor_data sensor_data;

void start_data_collection(char* time_str, char* usr_str);
void stop_data_collection();
