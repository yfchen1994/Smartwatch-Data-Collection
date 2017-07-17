#include <sensor.h>
#include <string.h>
#include "stdio.h"
#include "stdlib.h"
#include "main.h"
#include "sensorCollection.h"
#include <dlog.h>
#include <sys/stat.h>
#include <sys/types.h>



struct _sensor_info {
	// Sensor handle
	sensor_h sensor;
	// Sensor listener
	sensor_listener_h sensor_listener;
};

typedef struct _sensor_info sensorinfo_s;

static sensorinfo_s acc_info;
static sensorinfo_s gyr_info;


FILE* acc_fp;
FILE* gyr_fp;

// Store the sensor data in the following directory: "dir_path/file_name"
static void _data_collection(FILE* fwrite, char* input_data) {
	/*
	 * [in] frite: File to write
	 * [in] input_data: Sensor data to save
	 * */
    if (fwrite != NULL) {
    	fprintf(fwrite, "%s", input_data);
    }
}

// Callback function for lienar accelearation sensor event
static void _new_acceleartion_value(sensor_h sensor, sensor_event_s *sensor_data, void *user_data) {
	if (sensor_data->value_count < 3)
		return;
	char data[256];
	sprintf(data, "%llu\t%5.5f\t%5.5f\t%5.5f\n", sensor_data->timestamp, sensor_data->values[0],
			sensor_data->values[1], sensor_data->values[2]);
	_data_collection(acc_fp, data);
}

// Start acceleration sensor
static void start_accelerometer () {
	sensor_error_e err = SENSOR_ERROR_NONE;
	sensor_get_default_sensor(SENSOR_LINEAR_ACCELERATION, &acc_info.sensor);
	err = sensor_create_listener(acc_info.sensor, &acc_info.sensor_listener);
	sensor_listener_set_event_cb(acc_info.sensor_listener, 10, _new_acceleartion_value, NULL);
	int e = sensor_listener_start(acc_info.sensor_listener);
	if (e == SENSOR_ERROR_NONE) {
		dlog_print(DLOG_VERBOSE, "USR_TAG", "Accelerometer start!");
	}
}

static void stop_accelerometer() {
	int e = sensor_listener_stop(acc_info.sensor_listener);
	if (e == SENSOR_ERROR_NONE) {
		dlog_print(DLOG_VERBOSE, "USR_TAG", "Accelerometer stop!");
	}
}

// Callback function for gyroscope sensor event
static void _new_gyroscope_value(sensor_h sensor, sensor_event_s *sensor_data, void *user_data) {
	if (sensor_data->value_count < 3)
		return;
	char data[256];
	sprintf(data, "%llu\t%5.5f\t%5.5f\t%5.5f\n", sensor_data->timestamp, sensor_data->values[0],
			sensor_data->values[1], sensor_data->values[2]);
	_data_collection(gyr_fp, data);
}

// Start gyrosocope
static void start_gyroscope () {
	sensor_error_e err = SENSOR_ERROR_NONE;
	sensor_get_default_sensor(SENSOR_GYROSCOPE, &gyr_info.sensor);
	err = sensor_create_listener(gyr_info.sensor, &gyr_info.sensor_listener);
	sensor_listener_set_event_cb(gyr_info.sensor_listener, 10, _new_gyroscope_value, NULL);
	int e = sensor_listener_start(gyr_info.sensor_listener);
	if (e == SENSOR_ERROR_NONE) {
		dlog_print(DLOG_VERBOSE, "USR_TAG", "Gyroscope start!");
	}
}

static void stop_gyroscope() {
	int e = sensor_listener_stop(gyr_info.sensor_listener);
	if (e == SENSOR_ERROR_NONE) {
		dlog_print(DLOG_VERBOSE, "USR_TAG", "Gyroscope stop!");
	}
}

char acc_str[256];
char gyr_str[256];

void start_data_collection(char* time_str, char* usr_name) {

	const char ACC_MAIN_DIRECTORY[] = "/opt/usr/media/Downloads/yfchen_sensor_data/acc/";
	const char GYR_MAIN_DIRECTORY[] = "/opt/usr/media/Downloads/yfchen_sensor_data/gyr/";
	char acc_directory_str[256];
	char gyr_directory_str[256];
	char acc_file_str[256];
	char gyr_file_str[256];

	strcpy(acc_directory_str, ACC_MAIN_DIRECTORY);
	strcat(acc_directory_str, usr_name);
	strcat(acc_directory_str, "/");
	strcpy(gyr_directory_str, GYR_MAIN_DIRECTORY);
	strcat(gyr_directory_str, usr_name);
	strcat(gyr_directory_str, "/");

	strcpy(acc_file_str, acc_directory_str);
	strcat(acc_file_str, time_str);
	strcat(acc_file_str, "-acc.txt");
	strcpy(gyr_file_str, gyr_directory_str);
	strcat(gyr_file_str, time_str);
	strcat(gyr_file_str, "-gyr.txt");

    dlog_print(DLOG_VERBOSE, "USR_TAG", "%s", acc_file_str);
    dlog_print(DLOG_VERBOSE, "USR_TAG", "%s", gyr_file_str);

    if (access(acc_directory_str, 0) == -1) {
    	if (mkdir(acc_directory_str, 0777)) {
    		dlog_print(DLOG_VERBOSE, "USR_TAG", "Create acc dir failed!");
    	} else {
    		dlog_print(DLOG_VERBOSE, "USR_TAG", "Create acc dir successful!");
    	}
    }

    if (access(gyr_directory_str, 0) == -1) {
        	if (mkdir(gyr_directory_str, 0777)) {
        		dlog_print(DLOG_VERBOSE, "USR_TAG", "Create gyr dir failed!");
        	} else {
        		dlog_print(DLOG_VERBOSE, "USR_TAG", "Create gyr dir successful!");
        	}
        }


    strcpy(acc_str, acc_directory_str);
    strcpy(gyr_str, gyr_directory_str);
	acc_fp = fopen(acc_file_str, "w");
	gyr_fp = fopen(gyr_file_str, "w");
	if (acc_fp == NULL) {
		exit(EXIT_FAILURE);
	}
	start_accelerometer();
	start_gyroscope();
}

void stop_data_collection() {
	stop_accelerometer();
	stop_gyroscope();
    fclose(acc_fp);
    fclose(gyr_fp);
}

