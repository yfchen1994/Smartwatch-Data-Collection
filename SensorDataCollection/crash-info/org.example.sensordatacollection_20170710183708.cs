S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 27427
Date: 2017-07-10 18:37:08+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1c

Register Information
r0   = 0x43c49008, r1   = 0x413c0f04
r2   = 0xf9fefffe, r3   = 0x00000000
r4   = 0x405ac410, r5   = 0x43c49008
r6   = 0xbee48d10, r7   = 0x405ab000
r8   = 0x00000000, r9   = 0x40458824
r10  = 0x413c0f04, fp   = 0xbee48cfc
ip   = 0x413c0f04, sp   = 0xbee48790
lr   = 0x404baf50, pc   = 0x404baf74
cpsr = 0x00000010

Memory Information
MemTotal:   491132 KB
MemFree:      4932 KB
Buffers:     20196 KB
Cached:     125460 KB
VmPeak:     110000 KB
VmSize:     108980 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19540 KB
VmRSS:       19536 KB
VmData:      48344 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23272 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 27427 TID = 27427
27427 27446 27447 27448 27449 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f2000 40309000 r-xp /usr/lib/libecore.so.1.7.99
40320000 4037e000 r-xp /usr/lib/libedje.so.1.7.99
40388000 40458000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40459000 4045f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40467000 4046b000 r-xp /usr/lib/libsmack.so.1.0.0
40474000 4047c000 r-xp /lib/libgcc_s-4.6.so.1
4047d000 405a1000 r-xp /lib/libc-2.13.so
405af000 405cd000 r-xp /usr/lib/libsystemd.so.0.4.0
405d7000 405e2000 r-xp /lib/libunwind.so.8.0.1
4060f000 40626000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062e000 40658000 r-xp /usr/lib/libdbus-1.so.3.8.12
40661000 40666000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066e000 40691000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40699000 4069a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a2000 406a8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b1000 4071a000 r-xp /lib/libm-2.13.so
40723000 4073c000 r-xp /usr/lib/libeet.so.1.7.99
4074d000 4078e000 r-xp /usr/lib/libeina.so.1.7.99
40797000 407b9000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c2000 407c7000 r-xp /usr/lib/libecore_file.so.1.7.99
407cf000 407e0000 r-xp /usr/lib/libecore_input.so.1.7.99
407e8000 407f1000 r-xp /usr/lib/libvconf.so.0.2.45
407f9000 40849000 r-xp /usr/lib/libecore_x.so.1.7.99
4084b000 40854000 r-xp /usr/lib/libedbus.so.1.7.99
4085c000 40876000 r-xp /usr/lib/libecore_con.so.1.7.99
4087f000 40892000 r-xp /usr/lib/libfribidi.so.0.3.1
4089a000 408df000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a5a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a62000 40a65000 r-xp /lib/libcap.so.2.21
40a6d000 40a85000 r-xp /usr/lib/liblzma.so.5.0.3
40a8d000 40a9d000 r-xp /lib/libresolv-2.13.so
40aa1000 40b74000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b7f000 40bb3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbc000 40bd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bde000 40c53000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5d000 40c5f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c67000 40c7d000 r-xp /lib/libz.so.1.2.5
40c85000 40ca8000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc0000 40da1000 r-xp /usr/lib/libX11.so.6.3.0
40dac000 40db1000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dba000 40dbe000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc7000 40dca000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd2000 40dd9000 r-xp /usr/lib/libXcursor.so.1.0.2
40de1000 40de3000 r-xp /usr/lib/libXdamage.so.1.1.0
40deb000 40ded000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df5000 40df7000 r-xp /usr/lib/libXgesture.so.7.0.0
40dff000 40e02000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0a000 40e13000 r-xp /usr/lib/libXi.so.6.1.0
40e1b000 40e1c000 r-xp /usr/lib/libXinerama.so.1.0.0
40e25000 40e2b000 r-xp /usr/lib/libXrandr.so.2.2.0
40e33000 40e39000 r-xp /usr/lib/libXrender.so.1.3.0
40e41000 40e45000 r-xp /usr/lib/libXtst.so.6.1.0
40e4d000 40e57000 r-xp /usr/lib/libXext.so.6.4.0
40e60000 40ea4000 r-xp /usr/lib/libcurl.so.4.3.0
40ead000 40ec3000 r-xp /lib/libexpat.so.1.6.0
40ecd000 40ee5000 r-xp /usr/lib/libpng12.so.0.50.0
40eed000 40f0a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f13000 40fa7000 r-xp /usr/lib/libstdc++.so.6.0.16
40fba000 40fbd000 r-xp /lib/libattr.so.1.1.0
40fc5000 40fc6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fce000 40fd3000 r-xp /usr/lib/libffi.so.5.0.10
40fdc000 40fde000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe6000 410b2000 r-xp /usr/lib/libxml2.so.2.7.8
410bf000 410c1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410ca000 410cc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d4000 410e7000 r-xp /usr/lib/libxcb.so.1.1.0
410f1000 410fa000 r-xp /usr/lib/libcares.so.2.1.0
41103000 41131000 r-xp /usr/lib/libidn.so.11.5.44
41139000 41180000 r-xp /usr/lib/libssl.so.1.0.0
4118c000 4131e000 r-xp /usr/lib/libcrypto.so.1.0.0
41340000 41342000 r-xp /usr/lib/libiri.so
4134a000 41351000 r-xp /lib/libcrypt-2.13.so
41381000 41383000 r-xp /usr/lib/libXau.so.6.0.0
41390000 41394000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139c000 413a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a6000 413ab000 r-xp /usr/lib/libappcore-common.so.1.1
413b3000 413b5000 r-xp /usr/lib/libiniparser.so.0
413be000 413c2000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
413d4000 413d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e1000 413e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ec000 413f2000 r-xp /usr/lib/libappsvc.so.0.1.0
413fa000 4141e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41427000 414f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150c000 41516000 r-xp /lib/libnss_files-2.13.so
416b2000 416bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
416c8000 416d4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416dd000 416fe000 r-xp /usr/lib/libefl-extension.so.0.1.0
41706000 41730000 r-xp /usr/lib/libsensor.so.1.9.5
41739000 41740000 r-xp /usr/lib/libctx-shared.so.0.8.3
41748000 4174d000 r-xp /usr/lib/libctx-client.so.0.8.3
41755000 41767000 r-xp /usr/lib/libefl-assist.so.0.1.0
4176f000 41827000 r-xp /usr/lib/libcairo.so.2.11200.14
41832000 4183c000 r-xp /usr/lib/libsensord-shared.so
41844000 41853000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
4185c000 41872000 r-xp /usr/lib/libtts.so
4187b000 4189e000 r-xp /usr/lib/libui-extension.so.0.1.0
418a7000 418b2000 r-xp /usr/lib/libtbm.so.1.0.0
418ba000 418c8000 r-xp /usr/lib/libGLESv2.so.2.0
418d1000 418d2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418db000 418e1000 r-xp /usr/lib/libxcb-render.so.0.0.0
418e9000 418ec000 r-xp /usr/lib/libEGL.so.1.4
418f4000 418f9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41901000 41904000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4190c000 4190d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41916000 41a9e000 r-xp /usr/lib/libicui18n.so.57.1
41aae000 41bb4000 r-xp /usr/lib/libicuuc.so.57.1
41bca000 41bd2000 r-xp /usr/lib/libdrm.so.2.4.0
41bda000 41bdc000 r-xp /usr/lib/libdri2.so.0.0.0
41be4000 41bea000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bf2000 41bf7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41bff000 41c18000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41c20000 41c41000 r-xp /usr/lib/libexif.so.12.3.3
41c54000 41c56000 r-xp /usr/lib/libttrace.so.1.1
41c5e000 41c63000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41c6b000 41c71000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41c7a000 41c82000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41c8a000 41cac000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41cb5000 41cbc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41cc5000 41cc7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41ccf000 41cd6000 r-xp /usr/lib/libminizip.so.1.0.0
41cde000 41ceb000 r-xp /usr/lib/libail.so.0.1.0
41cf4000 41cfa000 r-xp /usr/lib/libproc-stat.so.0.2.96
41d02000 41d03000 r-xp /usr/lib/libresponse.so.0.2.96
41d0b000 41d10000 r-xp /usr/lib/libsystem.so.0.0.0
41d1e000 41e53000 rw-p [heap]
436ec000 437b6000 r-xp /usr/lib/libCOREGL.so.4.0
43b5b000 43b66000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43b6f000 43b74000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b7c000 43b93000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43ca0000 43ca2000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
444aa000 444ab000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
445ea000 44de9000 rw-p [stack:27446]
44dea000 455e9000 rw-p [stack:27447]
455ea000 45de9000 rw-p [stack:27448]
45dea000 46600000 rw-p [stack:27449]
bee29000 bee4a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27427)
Call Stack Count: 18
 0: _IO_vfprintf + 0xa4 (0x404baf74) [/lib/libc.so.6] + 0x3df74
 1: _IO_fprintf + 0x1c (0x404c4478) [/lib/libc.so.6] + 0x47478
 2: _data_collection + 0x2a (0x413c0b83) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2b83
 3: _new_acceleartion_value + 0x86 (0x413c0c7f) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2c7f
 4: (0x416d1127) [/usr/lib/libcapi-system-sensor.so.0] + 0x9127
 5: (0x4171aaf0) [/usr/lib/libsensor.so.1] + 0x14af0
 6: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 7: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 8: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 9: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
10: (0x402fe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
11: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x116 (0x413bfbf7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1bf7
15: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
16: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
17: create_base_gui + 0xe7 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
ror(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-10 18:37:04.028+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1013]   [com.samsung.w-home]register msg port [false][0m
07-10 18:37:04.028+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:37:04.028+0800 E/TBM     (  469): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:469] error(Device or resource busy) _tgl_destroy:141 key:37
07-10 18:37:04.033+0800 W/STARTER (  759): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[27349] goes to (3)
07-10 18:37:04.038+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3159
07-10 18:37:04.038+0800 I/APP_CORE(27349): appcore-efl.c: __do_app(453) > [APP 27349] Event: RESUME State: RUNNING
07-10 18:37:04.043+0800 I/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-10 18:37:04.043+0800 E/wnotib  (  824): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-10 18:37:04.043+0800 W/wnotib  (  824): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-10 18:37:04.053+0800 W/AUL     (  518): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(27349) status(fg) type(uiapp)
07-10 18:37:04.088+0800 W/APPS    (  824): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-10 18:37:04.368+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-10 18:37:04.373+0800 E/SHealthService( 1110): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-10 18:37:04.383+0800 W/SHealthService( 1110): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-10 18:37:04.413+0800 E/AUL     (  518): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 18:37:04.463+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-10 18:37:04.473+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-10 18:37:04.488+0800 W/SHealthCommon( 1110): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499644800000.000000[0;m
07-10 18:37:04.518+0800 W/SHealthCommon( 1110): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-10 18:37:04.523+0800 W/SHealthCommon( 1110): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 2[0;m
07-10 18:37:04.538+0800 I/HealthDataService(  999): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-10 18:37:04.538+0800 I/APP_CORE(  824): appcore-efl.c: __do_app(453) > [APP 824] Event: MEM_FLUSH State: PAUSED
07-10 18:37:04.563+0800 I/healthData( 1110): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-10 18:37:04.753+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:37:04.763+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27349
07-10 18:37:04.763+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:37:04.773+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27349
07-10 18:37:04.773+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 12
07-10 18:37:04.778+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 12
07-10 18:37:04.923+0800 E/EFL     (  469): ecore_x<469> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3600002 time=9926876
07-10 18:37:04.928+0800 E/EFL     (27349): ecore_x<27349> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=9926876
07-10 18:37:04.928+0800 E/EFL     (  469): ecore_x<469> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=9926876
07-10 18:37:05.033+0800 I/AUL_PAD (27427): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:37:06.628+0800 W/KEYROUTER(  469): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x3600002
07-10 18:37:06.703+0800 E/EFL     (27349): ecore_x<27349> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=9929012
07-10 18:37:06.753+0800 W/KEYROUTER(  469): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x3600002
07-10 18:37:06.753+0800 E/EFL     (27349): ecore_x<27349> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=9929166
07-10 18:37:06.753+0800 E/efl-extension(27349): efl_extension_events.c: _eext_key_grab_rect_key_up_cb(240) > key up called
07-10 18:37:06.753+0800 E/EFL     (27349): elementary<27349> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-10 18:37:06.753+0800 E/EFL     (27349): elementary<27349> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x44507860) will be popped.
07-10 18:37:06.753+0800 I/CAPI_APPFW_APPLICATION(27349): app_main.c: ui_app_exit(715) > ui_app_exit
07-10 18:37:06.753+0800 I/CAPI_APPFW_APPLICATION(27349): app_main.c: app_efl_exit(145) > app_efl_exit
07-10 18:37:06.763+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 22
07-10 18:37:06.763+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(999) > app status : 4
07-10 18:37:06.778+0800 W/APP_CORE(27349): appcore-efl.c: appcore_efl_main(1788) > power off : 0
07-10 18:37:06.793+0800 W/APP_CORE(27349): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[3600002] -> redirected win[600854] for org.example.sensordatacollection[27349]
07-10 18:37:06.908+0800 I/APP_CORE(27349): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
07-10 18:37:06.908+0800 I/APP_CORE(27349): appcore-efl.c: __after_loop(1234) > [APP 27349] PAUSE before termination
07-10 18:37:06.908+0800 I/CAPI_APPFW_APPLICATION(27349): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
07-10 18:37:06.908+0800 I/CAPI_APPFW_APPLICATION(27349): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
07-10 18:37:06.908+0800 I/APP_CORE(27349): appcore-efl.c: __after_loop(1243) > [APP 27349] After terminate() callback
07-10 18:37:06.933+0800 I/efl-extension(27349): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-10 18:37:06.933+0800 I/efl-extension(27349): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(962) > Private Surface will be initialized for widget[0x445073f8], circle_obj[0x4451d1d8]!
07-10 18:37:06.933+0800 I/efl-extension(27349): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(649) > surface 0x41754ea8 = w: 0 h: 0  obj 0x445073f8 w: 360 h: 360
07-10 18:37:06.938+0800 I/efl-extension(27349): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(673) > Surface will be initialized! surface->w= 360 surface->h = 360
07-10 18:37:06.938+0800 I/efl-extension(27349): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x43c362e0 is freed
07-10 18:37:06.938+0800 W/STARTER (  759): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[824] goes to (3)
07-10 18:37:06.938+0800 E/STARTER (  759): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 824)'s state(3)
07-10 18:37:06.938+0800 W/AUL_AMD (  518): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-10 18:37:06.938+0800 W/AUL_AMD (  518): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-10 18:37:06.938+0800 W/AUL     (  518): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(824) status(fg) type(uiapp)
07-10 18:37:06.943+0800 I/efl-extension(27349): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x4182bdb8 is freed
07-10 18:37:06.943+0800 I/efl-extension(27349): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x43ba0b98, obj: 0x43ba0b98
07-10 18:37:06.943+0800 I/efl-extension(27349): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
07-10 18:37:06.943+0800 I/efl-extension(27349): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
07-10 18:37:06.943+0800 I/efl-extension(27349): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
07-10 18:37:06.943+0800 I/efl-extension(27349): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-10 18:37:06.953+0800 E/EFL     (27349): elementary<27349> elm_genlist.c:6964 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-10 18:37:06.958+0800 E/EFL     (27349): elementary<27349> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x43ba0b98 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:37:06.958+0800 E/EFL     (27349): elementary<27349> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x43ba0b98 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-10 18:37:06.958+0800 E/EFL     (27349): elementary<27349> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x43ba0b98 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:37:06.958+0800 E/EFL     (27349): elementary<27349> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x43ba0b98 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-10 18:37:06.968+0800 I/efl-extension(27349): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-10 18:37:06.968+0800 I/efl-extension(27349): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x41754ea8 is freed
07-10 18:37:06.968+0800 I/efl-extension(27349): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x445073f8
07-10 18:37:06.968+0800 I/efl-extension(27349): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-10 18:37:06.968+0800 I/efl-extension(27349): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x43ba0b98, elm_genlist, func : 0x4183be89
07-10 18:37:06.968+0800 I/efl-extension(27349): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-10 18:37:06.968+0800 I/MALI    (  824): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-10 18:37:07.048+0800 I/UXT     (27349): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
07-10 18:37:07.103+0800 W/PROCESSMGR(  469): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
07-10 18:37:07.103+0800 W/W_HOME  (  824): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
07-10 18:37:07.103+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:07.103+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:07.113+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:07.113+0800 W/W_HOME  (  824): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
07-10 18:37:07.113+0800 W/WATCH_CORE(  904): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
07-10 18:37:07.113+0800 I/WATCH_CORE(  904): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
07-10 18:37:07.113+0800 I/CAPI_WATCH_APPLICATION(  904): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-10 18:37:07.113+0800 E/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(616) > 
07-10 18:37:07.113+0800 I/watchface-loader(  904): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-10 18:37:07.118+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 18:37:07.118+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 18:37:07.138+0800 W/W_HOME  (  824): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(0)
07-10 18:37:07.138+0800 W/W_HOME  (  824): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
07-10 18:37:07.138+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:07.138+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:07.138+0800 W/W_HOME  (  824): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(0)
07-10 18:37:07.138+0800 I/APP_CORE(  824): appcore-efl.c: __do_app(453) > [APP 824] Event: RESUME State: PAUSED
07-10 18:37:07.138+0800 I/CAPI_APPFW_APPLICATION(  824): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-10 18:37:07.138+0800 W/W_HOME  (  824): main.c: _appcore_resume_cb(478) > appcore resume
07-10 18:37:07.138+0800 W/W_HOME  (  824): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
07-10 18:37:07.138+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:07.138+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:07.138+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:07.138+0800 W/APPS    (  824): apps_main.c: _time_changed_cb(308) >  date : 10->10
07-10 18:37:07.138+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 18:37:07.138+0800 W/W_HOME  (  824): rotary.c: rotary_attach(138) > rotary_attach:0x473287a0
07-10 18:37:07.138+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x473287a0, elm_layout, _activated_obj : 0x460e3b10, activated : 1
07-10 18:37:07.138+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-10 18:37:07.138+0800 W/W_HOME  (  824): win.c: win_back_gesture_disable_set(170) > disable back gesture
07-10 18:37:07.138+0800 W/W_HOME  (  824): win.c: win_back_gesture_disable_set(170) > disable back gesture
07-10 18:37:07.143+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 18:37:07.143+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 18:37:07.148+0800 I/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
07-10 18:37:07.148+0800 E/wnotib  (  824): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-10 18:37:07.148+0800 W/wnotib  (  824): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
07-10 18:37:07.278+0800 I/efl-extension(27349): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-10 18:37:07.283+0800 W/AUL_PAD (27349): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
07-10 18:37:07.458+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 27349 pgid = 27349
07-10 18:37:07.458+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
07-10 18:37:07.558+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:37:07.568+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27349
07-10 18:37:07.568+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27349)
07-10 18:37:07.678+0800 I/MALI    (  824): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ecf218] swap changed from async to sync
07-10 18:37:07.743+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=9930159 button=1
07-10 18:37:07.743+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [310, 123]
07-10 18:37:07.743+0800 E/W_HOME  (  824): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-10 18:37:07.823+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=9930242 button=1
07-10 18:37:07.823+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [310, 123]->[300, 126]
07-10 18:37:07.828+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[32], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:37:07.828+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,32]
07-10 18:37:07.828+0800 E/APPS    (  824): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-10 18:37:07.828+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(487) >  item(sensordatacollection) launched, open(0), tts(0)
07-10 18:37:07.828+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 18:37:07.828+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 18:37:07.833+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 824
07-10 18:37:07.833+0800 I/AUL_AMD (  518): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-10 18:37:07.843+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 18:37:07.843+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 18:37:07.848+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 18:37:07.848+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 18:37:07.848+0800 W/AUL_PAD (27427): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 18:37:07.848+0800 W/AUL_PAD (27427): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 18:37:07.848+0800 W/AUL_PAD (27427): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 18:37:07.848+0800 W/AUL_PAD (27427): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 18:37:07.893+0800 I/efl-extension(27427): efl_extension.c: eext_mod_init(40) > Init
07-10 18:37:07.898+0800 I/UXT     (27427): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:37:07.903+0800 W/AUL_PAD (27427): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 18:37:07.903+0800 W/AUL_PAD (27427): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 18:37:07.903+0800 I/CAPI_APPFW_APPLICATION(27427): app_main.c: ui_app_main(704) > app_efl_main
07-10 18:37:07.903+0800 I/CAPI_APPFW_APPLICATION(27427): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 18:37:07.948+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(27427) type(uiapp) bg(0)
07-10 18:37:07.948+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (27427) was created
07-10 18:37:07.948+0800 E/AUL     (  518): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 18:37:07.948+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27427)
07-10 18:37:07.948+0800 W/W_HOME  (  824): util.c: apps_util_launch_main_operation(643) > Launch app:[sensordatacollection] ret:[0]
07-10 18:37:07.953+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27427]
07-10 18:37:08.068+0800 I/efl-extension(27427): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 18:37:08.068+0800 I/efl-extension(27427): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 18:37:08.068+0800 I/efl-extension(27427): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 18:37:08.073+0800 I/efl-extension(27427): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 18:37:08.073+0800 I/efl-extension(27427): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x43c58d08, elm_image, _activated_obj : 0x0, activated : 1
07-10 18:37:08.073+0800 E/EFL     (27427): elementary<27427> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 18:37:08.078+0800 E/EFL     (27427): elementary<27427> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x43c59170) will be pushed
07-10 18:37:08.078+0800 I/efl-extension(27427): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x43c48bf0]'s widget[0x43c5a600] to layout widget[0x43c59170]
07-10 18:37:08.078+0800 E/EFL     (27427): elementary<27427> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x43ba4b98 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:37:08.078+0800 E/EFL     (27427): elementary<27427> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x43ba4b98 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 18:37:08.078+0800 I/efl-extension(27427): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 18:37:08.083+0800 E/RESOURCED(  635): block-monitor.c: block_logging(123) > pid 27427(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-10-18--37-acc.txt
07-10 18:37:08.088+0800 E/RESOURCED(  635): block-monitor.c: block_logging(123) > pid 27427(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-10-18--37-gyr.txt
07-10 18:37:08.133+0800 I/APP_CORE(27427): appcore-efl.c: __do_app(453) > [APP 27427] Event: RESET State: CREATED
07-10 18:37:08.133+0800 I/CAPI_APPFW_APPLICATION(27427): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:37:08.143+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.143+0800 E/CAPI_APPFW_APP_CONTROL( 1013): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-10 18:37:08.143+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1013]   [com.samsung.w-home]register msg port [true][0m
07-10 18:37:08.143+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:37:08.153+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3159
07-10 18:37:08.153+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:37:08.158+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 824
07-10 18:37:08.168+0800 W/W_HOME  (  824): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-10 18:37:08.168+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:08.168+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:08.168+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:08.168+0800 W/W_HOME  (  824): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-10 18:37:08.168+0800 W/W_HOME  (  824): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-10 18:37:08.168+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1013]   [MUSIC_PLAYER_EVENT][0m
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:37:08.173+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.178+0800 W/W_HOME  (  824): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-10 18:37:08.178+0800 E/W_HOME  (  824): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-10 18:37:08.178+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1013]   [MUSIC_PLAYER_EVENT][0m
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.178+0800 W/W_HOME  (  824): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-10 18:37:08.178+0800 E/W_HOME  (  824): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:37:08.178+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.203+0800 I/APP_CORE(27427): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-10 18:37:08.203+0800 I/APP_CORE(27427): appcore-efl.c: __do_app(524) > [APP 27427] Initial Launching, call the resume_cb
07-10 18:37:08.203+0800 I/CAPI_APPFW_APPLICATION(27427): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-10 18:37:08.208+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 18:37:08.208+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 18:37:08.208+0800 W/APP_CORE(27427): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6000002
07-10 18:37:08.213+0800 E/EFL     (27427): elementary<27427> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x43ba4b98 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:37:08.213+0800 E/EFL     (27427): elementary<27427> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x43ba4b98 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-10 18:37:08.243+0800 E/EFL     (27427): elementary<27427> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x43ba4b98 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-10 18:37:08.243+0800 E/EFL     (27427): elementary<27427> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x43ba4b98 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-10 18:37:08.313+0800 W/W_HOME  (  824): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-10 18:37:08.313+0800 W/W_HOME  (  824): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-10 18:37:08.313+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:08.313+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:08.313+0800 W/W_HOME  (  824): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-10 18:37:08.313+0800 I/APP_CORE(  824): appcore-efl.c: __do_app(453) > [APP 824] Event: PAUSE State: RUNNING
07-10 18:37:08.313+0800 I/CAPI_APPFW_APPLICATION(  824): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-10 18:37:08.313+0800 W/W_HOME  (  824): main.c: _appcore_pause_cb(487) > appcore pause
07-10 18:37:08.313+0800 W/W_HOME  (  824): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-10 18:37:08.313+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:08.313+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:08.313+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:37:08.313+0800 W/W_HOME  (  824): rotary.c: rotary_deattach(156) > rotary_deattach:0x473287a0
07-10 18:37:08.313+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-10 18:37:08.313+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x473287a0, elm_layout, func : 0x4005653d
07-10 18:37:08.313+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-10 18:37:08.313+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-10 18:37:08.313+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-10 18:37:08.313+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e3b10, elm_box, _activated_obj : 0x473287a0, activated : 1
07-10 18:37:08.313+0800 I/efl-extension(  824): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-10 18:37:08.313+0800 E/wnotib  (  824): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-10 18:37:08.313+0800 I/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-10 18:37:08.318+0800 W/AUL     (  518): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(824) status(bg) type(uiapp)
07-10 18:37:08.323+0800 W/AUL     (  518): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(27427) status(fg) type(uiapp)
07-10 18:37:08.333+0800 W/STARTER (  759): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[824] goes to (4)
07-10 18:37:08.333+0800 E/STARTER (  759): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 824)'s state(4)
07-10 18:37:08.333+0800 W/STARTER (  759): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[27427] goes to (3)
07-10 18:37:08.343+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 18:37:08.348+0800 W/APPS    (  824): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[32]
07-10 18:37:08.348+0800 W/APPS    (  824): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-10 18:37:08.348+0800 W/APPS    (  824): AppsItem.cpp: aniFocusIndex(2351) >  [sensordatacollection:32] Focused[1], focusIdx[32]
07-10 18:37:08.353+0800 E/TBM     (  469): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:469] error(Device or resource busy) _tgl_destroy:141 key:37
07-10 18:37:08.363+0800 I/APP_CORE(27427): appcore-efl.c: __do_app(453) > [APP 27427] Event: RESUME State: RUNNING
07-10 18:37:08.368+0800 W/W_HOME  (  824): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-10 18:37:08.368+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.368+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.368+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.368+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-10 18:37:08.368+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-10 18:37:08.368+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.368+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-10 18:37:08.368+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-10 18:37:08.373+0800 I/MESSAGE_PORT(  477): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-10 18:37:08.373+0800 E/CAPI_APPFW_APP_CONTROL( 1013): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-10 18:37:08.373+0800 W/MUSIC_CONTROL_SERVICE( 1013): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1013]   [com.samsung.w-home]register msg port [false][0m
07-10 18:37:08.378+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 14
07-10 18:37:08.383+0800 W/AUL_AMD (  518): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3159
07-10 18:37:08.393+0800 I/wnotib  (  824): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-10 18:37:08.393+0800 E/wnotib  (  824): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-10 18:37:08.393+0800 W/wnotib  (  824): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-10 18:37:08.413+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 18:37:08.428+0800 W/APPS    (  824): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-10 18:37:08.553+0800 W/CRASH_MANAGER(27342): worker.c: worker_job(1205) > 112742773656e149968302
