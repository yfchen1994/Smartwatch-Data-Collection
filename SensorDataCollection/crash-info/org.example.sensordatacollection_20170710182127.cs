S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 25728
Date: 2017-07-10 18:21:27+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x4001345c
r2   = 0x400132b4, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x40003091
r6   = 0x40002ee3, r7   = 0xbeae3ff8
r8   = 0xbeae4faf, r9   = 0x00006480
r10  = 0x404f77e8, fp   = 0x00000000
ip   = 0x4035ab50, sp   = 0xbeae3d10
lr   = 0x40002ae9, pc   = 0x4035ab58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      3824 KB
Buffers:     21120 KB
Cached:     127776 KB
VmPeak:      92484 KB
VmSize:      91900 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17448 KB
VmRSS:       17448 KB
VmData:      30124 KB
VmStk:         136 KB
VmExe:          16 KB
VmLib:       24984 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 25728 TID = 25728
25728 25733 25734 25735 

Maps Information
40000000 40004000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
40006000 4000a000 r-xp /usr/lib/libsys-assert.so
40014000 40031000 r-xp /lib/ld-2.13.so
4003a000 40045000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40050000 40052000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4005b000 4005f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
40067000 40073000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
4007c000 40084000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
40085000 40087000 r-xp /usr/lib/libdlog.so.0.0.0
4008f000 400b0000 r-xp /usr/lib/libefl-extension.so.0.1.0
400b8000 401f4000 r-xp /usr/lib/libelementary.so.1.7.99
4020b000 402d9000 r-xp /usr/lib/libevas.so.1.7.99
402fe000 40422000 r-xp /lib/libc-2.13.so
40430000 40438000 r-xp /lib/libgcc_s-4.6.so.1
40439000 40444000 r-xp /lib/libunwind.so.8.0.1
40471000 40473000 r-xp /lib/libdl-2.13.so
4047c000 40489000 r-xp /usr/lib/libaul.so.0.1.0
40493000 404b6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
404be000 404d2000 r-xp /lib/libpthread-2.13.so
404dd000 404e1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404ea000 404f0000 r-xp /usr/lib/libappcore-efl.so.1.1
404f8000 404fd000 r-xp /usr/lib/libappcore-common.so.1.1
40505000 40546000 r-xp /usr/lib/libeina.so.1.7.99
4054f000 40579000 r-xp /usr/lib/libsensor.so.1.9.5
40582000 40589000 r-xp /usr/lib/libctx-shared.so.0.8.3
40591000 40596000 r-xp /usr/lib/libctx-client.so.0.8.3
4059e000 40632000 r-xp /usr/lib/libstdc++.so.6.0.16
40645000 406ae000 r-xp /lib/libm-2.13.so
406b7000 40707000 r-xp /usr/lib/libecore_x.so.1.7.99
40709000 4072b000 r-xp /usr/lib/libecore_evas.so.1.7.99
40734000 4073d000 r-xp /usr/lib/libvconf.so.0.2.45
40745000 4076d000 r-xp /usr/lib/libfontconfig.so.1.8.0
4076e000 4083a000 r-xp /usr/lib/libxml2.so.2.7.8
40847000 40917000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40918000 4092a000 r-xp /usr/lib/libefl-assist.so.0.1.0
40932000 40949000 r-xp /usr/lib/libecore.so.1.7.99
40960000 409be000 r-xp /usr/lib/libedje.so.1.7.99
409c8000 40a80000 r-xp /usr/lib/libcairo.so.2.11200.14
40a8b000 40b6c000 r-xp /usr/lib/libX11.so.6.3.0
40b77000 40b80000 r-xp /usr/lib/libXi.so.6.1.0
40b88000 40ba1000 r-xp /usr/lib/libeet.so.1.7.99
40bb2000 40bb7000 r-xp /usr/lib/libecore_file.so.1.7.99
40bbf000 40bd0000 r-xp /usr/lib/libecore_input.so.1.7.99
40bd8000 40be1000 r-xp /usr/lib/libedbus.so.1.7.99
40be9000 40c13000 r-xp /usr/lib/libdbus-1.so.3.8.12
40c1c000 40c36000 r-xp /usr/lib/libecore_con.so.1.7.99
40c3f000 40c52000 r-xp /usr/lib/libfribidi.so.0.3.1
40c5a000 40c9f000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
40ca8000 40cfe000 r-xp /usr/lib/libfreetype.so.6.11.3
40d0a000 40d60000 r-xp /usr/lib/libpixman-1.so.0.28.2
40d6d000 40d70000 r-xp /usr/lib/libbundle.so.0.1.22
40d78000 40d8f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40d98000 40d9d000 r-xp /usr/lib/libxdgmime.so.1.1.0
40da5000 40da6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
40dae000 40dcc000 r-xp /usr/lib/libsystemd.so.0.4.0
40dd6000 40df0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40df8000 40e6d000 r-xp /usr/lib/libsqlite3.so.0.8.6
40e78000 40e7e000 r-xp /usr/lib/libappsvc.so.0.1.0
40e86000 40e8c000 r-xp /usr/lib/libecore_imf.so.1.7.99
40e94000 40ec8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40ed1000 40ed3000 r-xp /usr/lib/libiniparser.so.0
40edc000 40ee2000 r-xp /lib/librt-2.13.so
40eec000 40fbf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40fca000 40fd0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
40fd9000 40fe3000 r-xp /usr/lib/libsensord-shared.so
40feb000 40ffa000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41003000 41032000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
4103b000 41042000 r-xp /usr/lib/libXcursor.so.1.0.2
4104a000 4104c000 r-xp /usr/lib/libXdamage.so.1.1.0
41054000 41056000 r-xp /usr/lib/libXcomposite.so.1.0.0
4105e000 41060000 r-xp /usr/lib/libXgesture.so.7.0.0
41068000 4106b000 r-xp /usr/lib/libXfixes.so.3.1.0
41074000 41075000 r-xp /usr/lib/libXinerama.so.1.0.0
4107e000 41084000 r-xp /usr/lib/libXrandr.so.2.2.0
4108c000 41092000 r-xp /usr/lib/libXrender.so.1.3.0
4109a000 4109e000 r-xp /usr/lib/libXtst.so.6.1.0
410a6000 410b0000 r-xp /usr/lib/libXext.so.6.4.0
410b9000 410be000 r-xp /usr/lib/libecore_fb.so.1.7.99
410c8000 410cc000 r-xp /usr/lib/libecore_ipc.so.1.7.99
410d5000 410d8000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
410e0000 410f6000 r-xp /lib/libexpat.so.1.6.0
41100000 41116000 r-xp /lib/libz.so.1.2.5
4111e000 41134000 r-xp /usr/lib/libtts.so
4113e000 41161000 r-xp /usr/lib/libui-extension.so.0.1.0
4116a000 41175000 r-xp /usr/lib/libtbm.so.1.0.0
4117d000 41184000 r-xp /usr/lib/libembryo.so.1.7.99
4118c000 411a3000 r-xp /usr/lib/liblua-5.1.so
411ac000 411ad000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
411b6000 411c4000 r-xp /usr/lib/libGLESv2.so.2.0
411cd000 411e5000 r-xp /usr/lib/libpng12.so.0.50.0
411ed000 411ee000 r-xp /usr/lib/libxcb-shm.so.0.0.0
411f7000 411fd000 r-xp /usr/lib/libxcb-render.so.0.0.0
41205000 41218000 r-xp /usr/lib/libxcb.so.1.1.0
41221000 41224000 r-xp /usr/lib/libEGL.so.1.4
4122d000 41250000 r-xp /usr/lib/libjpeg.so.8.0.2
41268000 412ac000 r-xp /usr/lib/libcurl.so.4.3.0
412b5000 412b7000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
412bf000 412d7000 r-xp /usr/lib/liblzma.so.5.0.3
412e0000 412f0000 r-xp /lib/libresolv-2.13.so
412f4000 412f6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
412ff000 41301000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41309000 4130a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41312000 41317000 r-xp /usr/lib/libffi.so.5.0.10
41320000 41322000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
4132a000 4132e000 r-xp /usr/lib/libsmack.so.1.0.0
41337000 41354000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4135d000 41362000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4136b000 4136e000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41376000 41377000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41380000 41508000 r-xp /usr/lib/libicui18n.so.57.1
41518000 4161e000 r-xp /usr/lib/libicuuc.so.57.1
41634000 4163c000 r-xp /usr/lib/libdrm.so.2.4.0
41645000 41647000 r-xp /usr/lib/libdri2.so.0.0.0
4164f000 41651000 r-xp /usr/lib/libXau.so.6.0.0
41659000 41662000 r-xp /usr/lib/libcares.so.2.1.0
4166b000 41699000 r-xp /usr/lib/libidn.so.11.5.44
416a1000 416e8000 r-xp /usr/lib/libssl.so.1.0.0
416f5000 41887000 r-xp /usr/lib/libcrypto.so.1.0.0
418a8000 418aa000 r-xp /usr/lib/libiri.so
418b2000 418b5000 r-xp /lib/libcap.so.2.21
418bd000 418c4000 r-xp /lib/libcrypt-2.13.so
418f5000 418fb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41903000 41908000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41910000 41929000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
431ca000 431cd000 r-xp /lib/libattr.so.1.1.0
431d6000 431f7000 r-xp /usr/lib/libexif.so.12.3.3
4320a000 4320c000 r-xp /usr/lib/libttrace.so.1.1
43214000 43219000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43221000 43227000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43230000 43238000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43241000 43263000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4326c000 43273000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4327c000 4327e000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43286000 4328d000 r-xp /usr/lib/libminizip.so.1.0.0
43295000 432a2000 r-xp /usr/lib/libail.so.0.1.0
432ac000 432b2000 r-xp /usr/lib/libproc-stat.so.0.2.96
432ba000 432bb000 r-xp /usr/lib/libresponse.so.0.2.96
432c3000 432c8000 r-xp /usr/lib/libsystem.so.0.0.0
433d8000 434a2000 r-xp /usr/lib/libCOREGL.so.4.0
434b4000 434d8000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
434e1000 435b0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
435c6000 435d0000 r-xp /lib/libnss_files-2.13.so
4396c000 439e1000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
439f1000 43b3a000 r-xp /usr/lib/egl/libMali.so
43b47000 43b4c000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b5d000 43b60000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43b69000 44368000 rw-p [stack:25733]
44369000 44b68000 rw-p [stack:25734]
44f1d000 44f34000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44f41000 44f43000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44f4c000 4574b000 rw-p [stack:25735]
4574b000 4574c000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
beac4000 beae5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25728)
Call Stack Count: 10
 0: fclose + 0x8 (0x4035ab58) [/lib/libc.so.6] + 0x5cb58
 1: start_data_collection + 0x110 (0x40002ae9) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2ae9
 2: create_base_gui + 0x152 (0x40001e77) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e77
 3: app_create + 0x12 (0x40001c6f) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1c6f
 4: (0x4005c9c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 5: appcore_efl_main + 0x246 (0x404eda5b) [/usr/lib/libappcore-efl.so.1] + 0x3a5b
 6: ui_app_main + 0xb0 (0x4005d421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: main + 0x116 (0x40001bf7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1bf7
 8: __libc_start_main + 0x114 (0x4031585c) [/lib/libc.so.6] + 0x1785c
 9: (0x400019fc) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x19fc
End of Call Stack

Package Information
Package Name: org.example.sensordatacollection
Package ID : org.example.sensordatacollection
Version: 1.0.0
Package Type: rpm
App Name: sensordatacollection
App ID: org.example.sensordatacollection
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
32.228+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25525 pgid = 25525
07-10 18:20:32.228+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-10 18:20:32.263+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 18:20:32.263+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 18:20:32.268+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 18:20:32.268+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(25525), proc(0)
07-10 18:20:32.268+0800 E/AUL     (  950): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 18:20:32.268+0800 E/CAPI_APPFW_APP_MANAGER(  950): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 18:20:32.268+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 18:20:32.268+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 18:20:32.268+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(25525), proc(0)
07-10 18:20:32.273+0800 E/AUL     ( 1110): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 18:20:32.273+0800 E/CAPI_APPFW_APP_MANAGER( 1110): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 18:20:32.273+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 18:20:32.373+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:20:32.378+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25525
07-10 18:20:32.383+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25525)
07-10 18:20:32.758+0800 I/AUL_PAD (25617): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:20:50.353+0800 W/SHealthCommon( 1110): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499644800000.000000[0;m
07-10 18:20:50.478+0800 W/SHealthCommon( 1110): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 2[0;m
07-10 18:20:50.523+0800 I/HealthDataService(  999): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-10 18:20:50.563+0800 I/healthData( 1110): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-10 18:21:00.613+0800 W/APPS    (  824): apps_main.c: _time_changed_cb(308) >  date : 10->10
07-10 18:21:16.818+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 18:21:17.923+0800 W/WATCH_CORE(  904): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-10 18:21:17.923+0800 I/WATCH_CORE(  904): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-10 18:21:17.933+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 18:21:17.933+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 18:21:17.933+0800 I/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-10 18:21:17.993+0800 E/wnoti-service( 1050): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-10 18:21:17.993+0800 E/wnoti-service( 1050): wnoti-native-client.c: handle_cache_notification(737) > >>
07-10 18:21:18.008+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-10 18:21:18.038+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-10 18:21:18.043+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-10 18:21:18.043+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-10 18:21:18.043+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-10 18:21:18.043+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-10 18:21:18.073+0800 W/SHealthService( 1110): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-10 18:21:18.098+0800 E/ALARM_MANAGER(  499): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(10-7-2017, 18:21:23), repeat(0), interval(0), type(-1073741822)
07-10 18:21:18.108+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [499].
07-10 18:21:18.173+0800 I/AUL     (  511): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 18:21:18.173+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 15
07-10 18:21:18.193+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 18:21:18.208+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-10 18:21:18.208+0800 E/ALARM_MANAGER(  511): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499682083, Mon Jul 10 18:21:23 2017
07-10 18:21:18.208+0800 E/ALARM_MANAGER(  511): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 54593921, next duetime: 1499682083
07-10 18:21:18.208+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(54593921)
07-10 18:21:18.208+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499691548), due_time(1499682083)
07-10 18:21:18.218+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-10 18:21:18.218+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-10 18:21:18.218+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 10-7-2017, 10:21:23 (UTC).
07-10 18:21:18.223+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-10 18:21:18.223+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 18:21:18.228+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-10 18:21:18.233+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 18:21:18.238+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:385> }
07-10 18:21:18.238+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:531> }
07-10 18:21:18.758+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:18.758+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 8981175
07-10 18:21:18.758+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5345) >  Touch canceled
07-10 18:21:18.763+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:19.038+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:19.038+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 8981454
07-10 18:21:19.038+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5365) >  __nTimeStamp:[0], __isFastMoving[0]
07-10 18:21:19.038+0800 W/APPS    (  824): AppsViewNecklace.cpp: runRotaryForwardAnimation(3576) >  EditMode[0], focusPage[2], focusIndex[23], ItemListSize[34], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
07-10 18:21:19.038+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[24], anim[0], autoLaunch[1], FocusNext[1], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:21:19.038+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 18:21:19.048+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:19.258+0800 W/APPS    (  824): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-10 18:21:19.433+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:19.433+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:19.433+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 8981848
07-10 18:21:19.433+0800 W/APPS    (  824): AppsViewNecklace.cpp: runRotaryForwardAnimation(3576) >  EditMode[0], focusPage[2], focusIndex[23], ItemListSize[34], FocusPrev[0], FocusNext[1], FocusRecent[0], HideNextPage[0]
07-10 18:21:19.433+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[24], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:21:19.433+0800 W/APPS    (  824): AppsItem.cpp: aniFocusIndex(2351) >  [电子邮件:24] Focused[0], focusIdx[24]
07-10 18:21:19.438+0800 W/APPS    (  824): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[24]
07-10 18:21:19.438+0800 W/APPS    (  824): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-10 18:21:19.438+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 18:21:19.453+0800 E/APPS    (  824): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(4083) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
07-10 18:21:19.588+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-10 18:21:19.593+0800 E/SHealthService( 1110): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-10 18:21:19.598+0800 W/SHealthService( 1110): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-10 18:21:19.673+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-10 18:21:19.693+0800 W/APPS    (  824): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-10 18:21:19.693+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-10 18:21:19.703+0800 W/SHealthCommon( 1110): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499644800000.000000[0;m
07-10 18:21:19.728+0800 W/SHealthCommon( 1110): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-10 18:21:19.733+0800 W/SHealthCommon( 1110): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 2[0;m
07-10 18:21:19.743+0800 I/HealthDataService(  999): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-10 18:21:19.763+0800 I/healthData( 1110): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-10 18:21:19.878+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8982290 button=1
07-10 18:21:19.878+0800 E/APPS    (  824): AppsViewNecklace.cpp: touchPressed(1624) >  (__isPageChanging) -> touchPressed() return
07-10 18:21:19.968+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8982388 button=1
07-10 18:21:19.973+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [272, 139]->[288, 137]
07-10 18:21:19.973+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(2011) >  touch cancel[0]
07-10 18:21:20.293+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.293+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.293+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 8982708
07-10 18:21:20.293+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5365) >  __nTimeStamp:[0], __isFastMoving[0]
07-10 18:21:20.293+0800 W/APPS    (  824): AppsViewNecklace.cpp: runRotaryForwardAnimation(3576) >  EditMode[0], focusPage[3], focusIndex[24], ItemListSize[34], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
07-10 18:21:20.293+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[25], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:21:20.298+0800 W/APPS    (  824): AppsItem.cpp: aniFocusIndex(2351) >  [uicomponents:25] Focused[0], focusIdx[25]
07-10 18:21:20.298+0800 W/APPS    (  824): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[25]
07-10 18:21:20.298+0800 W/APPS    (  824): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-10 18:21:20.298+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 18:21:20.318+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.333+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.333+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.333+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.338+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 8982731
07-10 18:21:20.338+0800 W/APPS    (  824): AppsViewNecklace.cpp: runRotaryForwardAnimation(3576) >  EditMode[0], focusPage[3], focusIndex[25], ItemListSize[34], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
07-10 18:21:20.343+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[31], anim[0], autoLaunch[1], FocusNext[1], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:21:20.343+0800 W/APPS    (  824): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-10 18:21:20.343+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 18:21:20.348+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 8982748
07-10 18:21:20.348+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5339) >  Ignore Rotary event because of fastmoving[1], launching[0]
07-10 18:21:20.563+0800 W/APPS    (  824): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-10 18:21:20.658+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.658+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.658+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 8983076
07-10 18:21:20.658+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5365) >  __nTimeStamp:[0], __isFastMoving[0]
07-10 18:21:20.663+0800 W/APPS    (  824): AppsViewNecklace.cpp: runRotaryForwardAnimation(3576) >  EditMode[0], focusPage[3], focusIndex[31], ItemListSize[34], FocusPrev[0], FocusNext[1], FocusRecent[0], HideNextPage[0]
07-10 18:21:20.663+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[32], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:21:20.663+0800 W/APPS    (  824): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[32]
07-10 18:21:20.663+0800 W/APPS    (  824): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-10 18:21:20.663+0800 W/APPS    (  824): AppsItem.cpp: aniFocusIndex(2351) >  [sensordatacollection:32] Focused[0], focusIdx[32]
07-10 18:21:20.668+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 18:21:20.678+0800 E/APPS    (  824): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(4083) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
07-10 18:21:20.708+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.728+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.753+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.753+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:21:20.753+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 8983126
07-10 18:21:20.753+0800 E/APPS    (  824): AppsViewNecklace.cpp: runRotaryForwardAnimation(3573) >  (__isPageChanging) -> runRotaryForwardAnimation() return
07-10 18:21:20.753+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 8983145
07-10 18:21:20.753+0800 E/APPS    (  824): AppsViewNecklace.cpp: runRotaryForwardAnimation(3573) >  (__isPageChanging) -> runRotaryForwardAnimation() return
07-10 18:21:20.898+0800 W/APPS    (  824): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-10 18:21:20.973+0800 E/EFL     (  469): ecore_x<469> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2e00003 time=8982388
07-10 18:21:20.988+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=8982388
07-10 18:21:20.988+0800 E/EFL     (  469): ecore_x<469> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=8982388
07-10 18:21:22.183+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8984598 button=1
07-10 18:21:22.183+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [313, 123]
07-10 18:21:22.183+0800 E/W_HOME  (  824): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-10 18:21:22.263+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8984677 button=1
07-10 18:21:22.268+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [313, 123]->[298, 125]
07-10 18:21:22.268+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[32], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:21:22.268+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,32]
07-10 18:21:22.268+0800 E/APPS    (  824): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-10 18:21:22.273+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(487) >  item(sensordatacollection) launched, open(0), tts(0)
07-10 18:21:22.278+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 18:21:22.278+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 18:21:22.283+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 824
07-10 18:21:22.283+0800 I/AUL_AMD (  518): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-10 18:21:22.293+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 18:21:22.293+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 18:21:22.293+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 18:21:22.298+0800 W/AUL_PAD (25617): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 18:21:22.298+0800 W/AUL_PAD (25617): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 18:21:22.298+0800 W/AUL_PAD (25617): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 18:21:22.298+0800 W/AUL_PAD (25617): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 18:21:22.308+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 18:21:22.363+0800 I/efl-extension(25617): efl_extension.c: eext_mod_init(40) > Init
07-10 18:21:22.368+0800 I/UXT     (25617): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:21:22.368+0800 W/AUL_PAD (25617): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 18:21:22.368+0800 W/AUL_PAD (25617): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 18:21:22.368+0800 I/CAPI_APPFW_APPLICATION(25617): app_main.c: ui_app_main(704) > app_efl_main
07-10 18:21:22.373+0800 I/CAPI_APPFW_APPLICATION(25617): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 18:21:22.398+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(25617) type(uiapp) bg(0)
07-10 18:21:22.398+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (25617) was created
07-10 18:21:22.398+0800 E/AUL     (  518): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 18:21:22.398+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25617)
07-10 18:21:22.398+0800 W/W_HOME  (  824): util.c: apps_util_launch_main_operation(643) > Launch app:[sensordatacollection] ret:[0]
07-10 18:21:22.418+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [25617]
07-10 18:21:22.533+0800 I/efl-extension(25617): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 18:21:22.538+0800 I/efl-extension(25617): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 18:21:22.538+0800 I/efl-extension(25617): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 18:21:22.538+0800 I/efl-extension(25617): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 18:21:22.538+0800 I/efl-extension(25617): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445073f8, elm_image, _activated_obj : 0x0, activated : 1
07-10 18:21:22.538+0800 E/EFL     (25617): elementary<25617> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 18:21:22.543+0800 E/EFL     (25617): elementary<25617> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44507860) will be pushed
07-10 18:21:22.543+0800 I/efl-extension(25617): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x417f66f0]'s widget[0x44508cf0] to layout widget[0x44507860]
07-10 18:21:22.548+0800 E/EFL     (25617): elementary<25617> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e95f0 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:21:22.548+0800 E/EFL     (25617): elementary<25617> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e95f0 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 18:21:22.548+0800 I/efl-extension(25617): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 18:21:22.768+0800 W/CRASH_MANAGER(25694): worker.c: worker_job(1205) > 112561773656e1499682082
07-10 18:21:22.998+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-10 18:21:23.003+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-10 18:21:23.013+0800 W/AUL     (  511): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(499) type(wakeup)
07-10 18:21:23.013+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_expired(1445) > alarm_id[54593921] is expired.
07-10 18:21:23.013+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 18:21:23.013+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(54593921)
07-10 18:21:23.013+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-10 18:21:23.013+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 10-7-2017, 12:59:08 (UTC).
07-10 18:21:23.013+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-10 18:21:23.013+0800 E/RESOURCED(  635): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 499
07-10 18:21:23.013+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-10 18:21:23.013+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-10 18:21:23.018+0800 E/ALARM_MANAGER(  499): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [54593921]
07-10 18:21:23.018+0800 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-10 18:21:23.018+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-10 18:21:23.018+0800 W/WECONN  (  499): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-10 18:21:23.018+0800 W/WECONN  (  499): <__connect_for_auto_switch:1706> { device=0x42903c78, device->bt_address=1E:F0
07-10 18:21:23.023+0800 E/ALARM_MANAGER(  511): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-10 18:21:23.088+0800 W/WECONN  (  499): <__connect_for_auto_switch:1719> }
07-10 18:21:23.088+0800 W/WECONN  (  499):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-10 18:21:23.093+0800 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:185> }
07-10 18:21:23.443+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25617 pgid = 25617
07-10 18:21:23.443+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-10 18:21:23.453+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 18:21:23.453+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 18:21:23.453+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(25617), proc(0)
07-10 18:21:23.453+0800 E/AUL     ( 1110): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 18:21:23.453+0800 E/CAPI_APPFW_APP_MANAGER( 1110): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 18:21:23.458+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 18:21:23.463+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 18:21:23.463+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 18:21:23.463+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(25617), proc(0)
07-10 18:21:23.463+0800 E/AUL     (  950): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 18:21:23.463+0800 E/CAPI_APPFW_APP_MANAGER(  950): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 18:21:23.468+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 18:21:23.498+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:21:23.498+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25617
07-10 18:21:23.498+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25617)
07-10 18:21:23.728+0800 I/AUL_PAD (25706): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:21:24.133+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8986552 button=1
07-10 18:21:24.133+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [325, 113]
07-10 18:21:24.138+0800 E/W_HOME  (  824): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-10 18:21:24.273+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8986692 button=1
07-10 18:21:24.273+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [325, 113]->[292, 122]
07-10 18:21:24.273+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[32], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:21:24.273+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,32]
07-10 18:21:24.278+0800 E/APPS    (  824): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-10 18:21:24.278+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(487) >  item(sensordatacollection) launched, open(0), tts(0)
07-10 18:21:24.278+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 18:21:24.283+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 18:21:24.283+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 824
07-10 18:21:24.283+0800 I/AUL_AMD (  518): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-10 18:21:24.293+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 18:21:24.293+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 18:21:24.293+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 18:21:24.298+0800 W/AUL_PAD (25706): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 18:21:24.298+0800 W/AUL_PAD (25706): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 18:21:24.298+0800 W/AUL_PAD (25706): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 18:21:24.298+0800 W/AUL_PAD (25706): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 18:21:24.303+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 18:21:24.348+0800 I/efl-extension(25706): efl_extension.c: eext_mod_init(40) > Init
07-10 18:21:24.348+0800 I/UXT     (25706): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:21:24.353+0800 W/AUL_PAD (25706): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 18:21:24.353+0800 W/AUL_PAD (25706): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 18:21:24.353+0800 I/CAPI_APPFW_APPLICATION(25706): app_main.c: ui_app_main(704) > app_efl_main
07-10 18:21:24.358+0800 I/CAPI_APPFW_APPLICATION(25706): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 18:21:24.393+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(25706) type(uiapp) bg(0)
07-10 18:21:24.398+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25706)
07-10 18:21:24.398+0800 W/W_HOME  (  824): util.c: apps_util_launch_main_operation(643) > Launch app:[sensordatacollection] ret:[0]
07-10 18:21:24.398+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (25706) was created
07-10 18:21:24.398+0800 E/AUL     (  518): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 18:21:24.403+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [25706]
07-10 18:21:24.533+0800 I/efl-extension(25706): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 18:21:24.533+0800 I/efl-extension(25706): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 18:21:24.533+0800 I/efl-extension(25706): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 18:21:24.538+0800 I/efl-extension(25706): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 18:21:24.538+0800 I/efl-extension(25706): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4450fdf8, elm_image, _activated_obj : 0x0, activated : 1
07-10 18:21:24.538+0800 E/EFL     (25706): elementary<25706> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 18:21:24.543+0800 E/EFL     (25706): elementary<25706> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44510260) will be pushed
07-10 18:21:24.543+0800 I/efl-extension(25706): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x41835c50]'s widget[0x445116f0] to layout widget[0x44510260]
07-10 18:21:24.548+0800 E/EFL     (25706): elementary<25706> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4181ec70 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:21:24.548+0800 E/EFL     (25706): elementary<25706> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4181ec70 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 18:21:24.548+0800 I/efl-extension(25706): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 18:21:24.573+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8986991 button=1
07-10 18:21:24.653+0800 W/CRASH_MANAGER(25694): worker.c: worker_job(1205) > 112570673656e1499682084
07-10 18:21:24.668+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8987088 button=1
07-10 18:21:24.918+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8987336 button=1
07-10 18:21:25.013+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8987433 button=1
07-10 18:21:25.238+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8987656 button=1
07-10 18:21:25.368+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8987786 button=1
07-10 18:21:25.448+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25706 pgid = 25706
07-10 18:21:25.448+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-10 18:21:25.463+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 18:21:25.463+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 18:21:25.463+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(25706), proc(0)
07-10 18:21:25.463+0800 E/AUL     (  950): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 18:21:25.463+0800 E/CAPI_APPFW_APP_MANAGER(  950): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 18:21:25.463+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 18:21:25.473+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 18:21:25.473+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 18:21:25.473+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(25706), proc(0)
07-10 18:21:25.473+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 18:21:25.473+0800 E/AUL     ( 1110): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 18:21:25.473+0800 E/CAPI_APPFW_APP_MANAGER( 1110): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 18:21:25.528+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:21:25.533+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25706
07-10 18:21:25.533+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25706)
07-10 18:21:25.623+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8988040 button=1
07-10 18:21:25.623+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [303, 111]
07-10 18:21:25.623+0800 E/W_HOME  (  824): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-10 18:21:25.763+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8988181 button=1
07-10 18:21:25.763+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [303, 111]->[288, 117]
07-10 18:21:25.763+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[32], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:21:25.763+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,32]
07-10 18:21:25.763+0800 E/APPS    (  824): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-10 18:21:25.763+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(487) >  item(sensordatacollection) launched, open(0), tts(0)
07-10 18:21:25.763+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 18:21:25.763+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 18:21:25.768+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 824
07-10 18:21:25.768+0800 I/AUL_AMD (  518): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-10 18:21:25.778+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 18:21:25.778+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(630) > Candidate is not prepared, enter legacy logic
07-10 18:21:25.778+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 18:21:25.778+0800 E/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(278) > launching failed
07-10 18:21:25.778+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2229) > Launch with legacy way : no launchpad
07-10 18:21:25.783+0800 W/AUL_AMD (  518): amd_launch.c: start_process(606) > child process: 25728
07-10 18:21:25.783+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 18:21:25.833+0800 W/AUL_AMD (  518): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 25728
07-10 18:21:25.833+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(25728) type(uiapp) bg(0)
07-10 18:21:25.833+0800 E/AUL     (  518): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 18:21:25.833+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25728)
07-10 18:21:25.833+0800 W/W_HOME  (  824): util.c: apps_util_launch_main_operation(643) > Launch app:[sensordatacollection] ret:[0]
07-10 18:21:25.838+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [25728]
07-10 18:21:25.858+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:21:25.863+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 25728
07-10 18:21:25.883+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:21:25.893+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 25728
07-10 18:21:25.893+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 12
07-10 18:21:26.033+0800 I/efl-extension(25728): efl_extension.c: eext_mod_init(40) > Init
07-10 18:21:26.073+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 12
07-10 18:21:26.078+0800 I/CAPI_APPFW_APPLICATION(25728): app_main.c: ui_app_main(704) > app_efl_main
07-10 18:21:26.118+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8988535 button=1
07-10 18:21:26.143+0800 I/UXT     (25728): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:21:26.238+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8988654 button=1
07-10 18:21:26.448+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (25728) was created
07-10 18:21:26.458+0800 I/CAPI_APPFW_APPLICATION(25728): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 18:21:26.538+0800 E/MALI    (25728): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 18:21:26.538+0800 E/MALI    (25728): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 18:21:26.538+0800 E/MALI    (25728): [gpu-ddk] devel/graphics_drv/r4p0
07-10 18:21:26.538+0800 E/MALI    (25728): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 18:21:26.538+0800 E/MALI    (25728): [coregl] devel/graphics_engine/master
07-10 18:21:26.538+0800 E/MALI    (25728): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 18:21:26.538+0800 E/MALI    (25728): 
07-10 18:21:26.608+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8989027 button=1
07-10 18:21:26.718+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8989135 button=1
07-10 18:21:27.028+0800 I/efl-extension(25728): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 18:21:27.028+0800 I/efl-extension(25728): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 18:21:27.028+0800 I/efl-extension(25728): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 18:21:27.043+0800 I/efl-extension(25728): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 18:21:27.043+0800 I/efl-extension(25728): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44e2d848, elm_image, _activated_obj : 0x0, activated : 1
07-10 18:21:27.043+0800 E/EFL     (25728): elementary<25728> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 18:21:27.048+0800 E/EFL     (25728): elementary<25728> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44e2dcb0) will be pushed
07-10 18:21:27.048+0800 I/efl-extension(25728): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44eeea20]'s widget[0x44e2f140] to layout widget[0x44e2dcb0]
07-10 18:21:27.063+0800 E/EFL     (25728): elementary<25728> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44e229f8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:21:27.063+0800 E/EFL     (25728): elementary<25728> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44e229f8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 18:21:27.063+0800 I/efl-extension(25728): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 18:21:28.228+0800 W/WECONN  (  499): <__on_connect_socket:378> {
07-10 18:21:28.228+0800 W/WECONN  (  499): <__is_device_matched_to:2560> le : , br_edr : 1E:F0, identifier : 1E:F0
07-10 18:21:28.228+0800 W/WECONN  (  499): <__on_connect_socket:383> result(-29359863), state(0)
07-10 18:21:28.228+0800 W/WECONN  (  499): <__on_connect_socket:387> }
07-10 18:21:29.203+0800 W/AUL     (25740): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.sensordatacollection]
07-10 18:21:29.218+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 23
07-10 18:21:29.218+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
07-10 18:21:29.218+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9192
07-10 18:21:29.218+0800 W/AUL_AMD (  518): amd_request.c: __send_app_termination_signal(528) > send dead signal done
07-10 18:21:29.223+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9192
07-10 18:21:29.223+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9192)
07-10 18:21:31.353+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 18:21:31.838+0800 I/AUL_PAD (25721): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:21:33.648+0800 W/CRASH_MANAGER(25694): worker.c: worker_job(1205) > 112572873656e149968208
