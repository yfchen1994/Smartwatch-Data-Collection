S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 26184
Date: 2017-07-10 18:24:12+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x414c0d26
r2   = 0x414c0d26, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x414c0bc3
r6   = 0x414c0b8f, r7   = 0xbed56208
r8   = 0x414728cb, r9   = 0x00006648
r10  = 0x4004e7e8, fp   = 0x00000000
ip   = 0x404d9b50, sp   = 0xbed55f20
lr   = 0x414c09b3, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      8400 KB
Buffers:     21140 KB
Cached:     125644 KB
VmPeak:      72888 KB
VmSize:      72888 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14788 KB
VmRSS:       14788 KB
VmData:      13456 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22904 KB
VmPTE:          44 KB
VmSwap:          0 KB

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
41490000 41494000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4149c000 414a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414a6000 414ab000 r-xp /usr/lib/libappcore-common.so.1.1
414b3000 414b5000 r-xp /usr/lib/libiniparser.so.0
414be000 414c1000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418c8000 418e9000 r-xp /usr/lib/libefl-extension.so.0.1.0
418f1000 41903000 r-xp /usr/lib/libefl-assist.so.0.1.0
4190b000 419c3000 r-xp /usr/lib/libcairo.so.2.11200.14
419ce000 419e4000 r-xp /usr/lib/libtts.so
419ed000 41a10000 r-xp /usr/lib/libui-extension.so.0.1.0
41a19000 41a24000 r-xp /usr/lib/libtbm.so.1.0.0
41a2c000 41a3a000 r-xp /usr/lib/libGLESv2.so.2.0
41a43000 41a44000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a4d000 41a53000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a5b000 41a5e000 r-xp /usr/lib/libEGL.so.1.4
41a66000 41a6b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a73000 41a76000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a7e000 41a7f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a88000 41c10000 r-xp /usr/lib/libicui18n.so.57.1
41c20000 41d26000 r-xp /usr/lib/libicuuc.so.57.1
41d3c000 41d44000 r-xp /usr/lib/libdrm.so.2.4.0
41d4c000 41d4e000 r-xp /usr/lib/libdri2.so.0.0.0
41d56000 41d5c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d64000 41d69000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d71000 41d8a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4362b000 4364c000 r-xp /usr/lib/libexif.so.12.3.3
4365f000 43661000 r-xp /usr/lib/libttrace.so.1.1
43669000 4366e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43676000 4367c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43685000 4368d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43695000 436b7000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
436c0000 436c7000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436d0000 436d2000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436da000 436e1000 r-xp /usr/lib/libminizip.so.1.0.0
436e9000 436f6000 r-xp /usr/lib/libail.so.0.1.0
436ff000 43705000 r-xp /usr/lib/libproc-stat.so.0.2.96
4370d000 4370e000 r-xp /usr/lib/libresponse.so.0.2.96
43716000 4371b000 r-xp /usr/lib/libsystem.so.0.0.0
43725000 437ef000 r-xp /usr/lib/libCOREGL.so.4.0
43b94000 43b9f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ba8000 43bad000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43bb5000 43bcc000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43bd9000 43bdb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
444e3000 444e4000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
bed36000 bed57000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26184)
Call Stack Count: 11
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: start_data_collection + 0x12a (0x414c09b3) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x29b3
 2: create_base_gui + 0x152 (0x414bfd27) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1d27
 3: app_create + 0x12 (0x414bfb1f) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1b1f
 4: (0x414919c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 5: appcore_efl_main + 0x246 (0x40044a5b) [/usr/lib/libappcore-efl.so.1] + 0x3a5b
 6: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: main + 0x116 (0x414bfaa7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1aa7
 8: main + 0xc2 (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
 9: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
10: create_list_view + 0x97 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
e( 1110): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-10 18:23:00.673+0800 W/APPS    (  824): apps_main.c: _time_changed_cb(308) >  date : 10->10
07-10 18:23:13.648+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-10 18:23:13.713+0800 E/SHealthService( 1110): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-10 18:23:13.758+0800 W/SHealthService( 1110): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(379) > [1;40;33mOnNotWearingStart[0;m
07-10 18:23:13.873+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-10 18:23:13.888+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-10 18:23:13.903+0800 W/SHealthCommon( 1110): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499644800000.000000[0;m
07-10 18:23:13.923+0800 W/SHealthCommon( 1110): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-10 18:23:13.928+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-10 18:23:13.938+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-10 18:23:13.948+0800 W/SHealthService( 1110): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-10 18:23:13.963+0800 W/SHealthCommon( 1110): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 2[0;m
07-10 18:23:13.973+0800 I/HealthDataService(  999): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-10 18:23:13.988+0800 I/healthData( 1110): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-10 18:23:21.708+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 18:23:21.888+0800 E/PKGMGR  (26066): pkgmgr.c: pkgmgr_client_install(1651) > install pkg start.
07-10 18:23:22.123+0800 E/PKGMGR_SERVER(26068): pkgmgr-server.c: main(2242) > package manager server start
07-10 18:23:22.258+0800 E/PKGMGR  (26068): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk is core
07-10 18:23:22.258+0800 E/PKGMGR  (26068): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk is core
07-10 18:23:22.263+0800 E/rpm-installer(26068): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
07-10 18:23:22.268+0800 E/BACKEND_LIB(26068): librpm.c: __is_symlink_file(70) > file is safe
07-10 18:23:22.283+0800 E/PKGMGR_SERVER(26068): pm-mdm.c: _pm_check_mdm_policy(1063) > [0;31m[_pm_check_mdm_policy(): 1063](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
07-10 18:23:22.283+0800 E/PKGMGR  (26066): pkgmgr.c: pkgmgr_client_install(1768) > install pkg finish, ret=[260660002]
07-10 18:23:22.288+0800 E/PKGMGR_SERVER(26069): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk]
07-10 18:23:22.293+0800 E/PKGMGR_SERVER(26070): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
07-10 18:23:22.383+0800 E/rpm-installer(26069): rpm-appcore-intf.c: main(120) > ------------------------------------------------
07-10 18:23:22.383+0800 E/rpm-installer(26069): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
07-10 18:23:22.383+0800 E/rpm-installer(26069): rpm-appcore-intf.c: main(122) > ------------------------------------------------
07-10 18:23:22.408+0800 E/PKGMGR_OBSERVER(26070): pkg_observer.c: main(601) > OBSERVER start
07-10 18:23:22.518+0800 E/rpm-installer(26069): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk] is tpk package.
07-10 18:23:22.528+0800 E/rpm-installer(26069): coretpk-parser.c: __coretpk_parser_get_value(1713) > (result_value == NULL) [install-location] is empty.
07-10 18:23:22.528+0800 E/rpm-installer(26069): coretpk-parser.c: __coretpk_parser_get_value_list(1670) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
07-10 18:23:22.528+0800 E/rpm-installer(26069): coretpk-parser.c: _coretpk_parser_is_widget(1586) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget'])
07-10 18:23:22.528+0800 E/rpm-installer(26069): coretpk-parser.c: _coretpk_parser_is_custom_clock(1480) > (ret == 1) metadata(watchface) is empty.
07-10 18:23:22.528+0800 E/rpm-installer(26069): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.sensordatacollection/) failed. [2][No such file or directory]
07-10 18:23:22.528+0800 E/rpm-installer(26069): coretpk-installer.c: _coretpk_installer_install_package(3579) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.sensordatacollection/]
07-10 18:23:22.608+0800 E/PKGMGR_OBSERVER(26070): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[260700002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[start] val[install]
07-10 18:23:22.638+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(start), value(install)
07-10 18:23:22.643+0800 E/PKGMGR_OBSERVER(26070): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[260700002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[30]
07-10 18:23:22.668+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, STARTED]
07-10 18:23:22.688+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 18:23:22.803+0800 W/CERT_SVC(26069): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
07-10 18:23:22.828+0800 E/rpm-installer(26069): coretpk-parser.c: __coretpk_parser_verify_metadata(48) > (ret == 1) metadata is empty.
07-10 18:23:22.828+0800 E/rpm-installer(26069): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
07-10 18:23:22.828+0800 E/rpm-installer(26069): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
07-10 18:23:22.828+0800 E/rpm-installer(26069): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
07-10 18:23:22.888+0800 E/PKGMGR_PARSER(26069): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
07-10 18:23:22.893+0800 E/PKGMGR_PARSER(26069): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/org.example.sensordatacollection.xml
07-10 18:23:22.898+0800 E/PKGMGR_PARSER(26069): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
07-10 18:23:22.898+0800 E/PKGMGR_PARSER(26069): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
07-10 18:23:23.043+0800 I/efl-extension(26069): efl_extension.c: eext_mod_init(40) > Init
07-10 18:23:23.048+0800 I/efl-extension(26069): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-10 18:23:23.133+0800 E/PKGMGR_PARSER(26069): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
07-10 18:23:23.163+0800 E/PKGMGR_CERT(26069): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
07-10 18:23:23.163+0800 E/PKGMGR_CERT(26069): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 120
07-10 18:23:23.163+0800 E/PKGMGR_CERT(26069): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 120
07-10 18:23:23.163+0800 E/PKGMGR_CERT(26069): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 29 6
07-10 18:23:23.163+0800 E/PKGMGR_CERT(26069): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 14
07-10 18:23:23.163+0800 E/PKGMGR_CERT(26069): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 14
07-10 18:23:23.168+0800 E/PKGMGR_CERT(26069): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 30 6
07-10 18:23:23.183+0800 E/PKGMGR_CERT(26069): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
07-10 18:23:23.198+0800 E/PKGMGR_OBSERVER(26070): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[260700002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[60]
07-10 18:23:23.223+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 18:23:23.273+0800 E/rpm-installer(26069): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
07-10 18:23:23.283+0800 E/rpm-installer(26069): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [z0QlgvtZWc7MUAsAHX1kZCd6NyfN6kalPinZVqoqrqE=] for shared/trusted.
07-10 18:23:23.293+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25892 pgid = 25892
07-10 18:23:23.293+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-10 18:23:23.328+0800 E/rpm-installer(26069): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
07-10 18:23:23.373+0800 E/PKGMGR_OBSERVER(26070): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[260700002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[100]
07-10 18:23:23.393+0800 E/rpm-installer(26069): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
07-10 18:23:23.423+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25892
07-10 18:23:23.423+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25892)
07-10 18:23:23.448+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-10 18:23:23.488+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:23:23.488+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25894 pgid = -1
07-10 18:23:23.488+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-10 18:23:23.488+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:23:23.498+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25894
07-10 18:23:23.498+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25894)
07-10 18:23:23.873+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25893
07-10 18:23:23.873+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25893)
07-10 18:23:24.123+0800 I/AUL_PAD (26079): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:23:24.583+0800 E/PKGMGR_SERVER(26068): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:23:24.918+0800 I/efl-extension(26080): efl_extension.c: eext_mod_init(40) > Init
07-10 18:23:25.168+0800 I/UXT     (26080): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:23:25.288+0800 I/AUL_PAD (26080): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:23:25.313+0800 E/MALI    (26080): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 18:23:25.313+0800 E/MALI    (26080): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 18:23:25.313+0800 E/MALI    (26080): [gpu-ddk] devel/graphics_drv/r4p0
07-10 18:23:25.313+0800 E/MALI    (26080): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 18:23:25.313+0800 E/MALI    (26080): [coregl] devel/graphics_engine/master
07-10 18:23:25.313+0800 E/MALI    (26080): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 18:23:25.313+0800 E/MALI    (26080): �
07-10 18:23:25.503+0800 E/PKGMGR_OBSERVER(26070): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[260700002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[ok]
07-10 18:23:25.548+0800 W/AUL_AMD (  518): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(ok)
07-10 18:23:25.583+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, COMPLETED]
07-10 18:23:25.583+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-10 18:23:25.583+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-10 18:23:25.583+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-10 18:23:25.583+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-10 18:23:25.658+0800 E/STARTER (  759): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-10 18:23:25.678+0800 E/WMS     (  516): wms_db.c: wms_db_package_event_insert_record(190) > 
07-10 18:23:25.688+0800 E/PKGMGR_INFO(26070): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-10 18:23:25.693+0800 W/SVOICE  ( 3159): DomainAppState.cpp: operator()(64) > [0;32mINFO: Apps info changed. SetUploadSyncCondition[0;m
07-10 18:23:25.693+0800 W/SVOICE  ( 3159): PreferenceKey.cpp: SetUploadSyncCondition(551) > [0;32mINFO: UploadManager need to Sync : 1[0;m
07-10 18:23:25.693+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-10 18:23:25.723+0800 E/PKGMGR_INFO(  513): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-10 18:23:25.723+0800 E/PKGMGR_OBSERVER(26070): pkg_observer.c: main(620) > OBSERVER end
07-10 18:23:25.753+0800 E/PKGMGR_SERVER(26068): pkgmgr-server.c: sighandler(486) > child NORMAL exit [26070]
07-10 18:23:25.768+0800 W/APPS    (  824): AppsViewNecklace.cpp: onAddItem(356) >  [sensordatacollection]
07-10 18:23:25.823+0800 W/APPS    (  824): AppsBadge.cpp: onBadgeInit(124) >  [sensordatacollection] Badge is not exist
07-10 18:23:25.823+0800 W/APPS    (  824): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[31]
07-10 18:23:25.823+0800 W/APPS    (  824): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [1->0]
07-10 18:23:25.828+0800 E/Vi::Animations(  824): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
07-10 18:23:25.828+0800 I/Vi::Animations(  824): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
07-10 18:23:25.833+0800 E/EFL     (  824): elementary<824> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x47d315d0 into part 'elm.swallow.event.0'
07-10 18:23:25.838+0800 W/APPS    (  824): AppsItem.cpp: aniFocusIndex(2351) >  [sensoraccelerator:31] Focused[0], focusIdx[31]
07-10 18:23:25.838+0800 W/APPS    (  824): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[31]
07-10 18:23:25.838+0800 W/APPS    (  824): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-10 18:23:25.888+0800 W/MM_CAMCORDER(26081): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
07-10 18:23:25.888+0800 W/MM_CAMCORDER(26081): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
07-10 18:23:25.948+0800 I/efl-extension(26081): efl_extension.c: eext_mod_init(40) > Init
07-10 18:23:26.583+0800 E/PKGMGR_SERVER(26068): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:23:26.863+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:26.898+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:26.898+0800 E/AUL     (26081): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:23:26.898+0800 E/AUL     (26081): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:23:26.923+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:26.943+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:26.953+0800 E/AUL     (26081): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:23:26.953+0800 E/AUL     (26081): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:23:26.983+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.008+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.008+0800 E/AUL     (26081): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:23:27.008+0800 E/AUL     (26081): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:23:27.023+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.038+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.038+0800 E/AUL     (26081): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:23:27.038+0800 E/AUL     (26081): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:23:27.053+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.063+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.068+0800 E/AUL     (26081): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:23:27.068+0800 E/AUL     (26081): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:23:27.078+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.093+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.093+0800 E/AUL     (26081): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:23:27.093+0800 E/AUL     (26081): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:23:27.108+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.123+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.123+0800 E/AUL     (26081): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:23:27.123+0800 E/AUL     (26081): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:23:27.133+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.148+0800 I/AUL     (26081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:27.148+0800 E/AUL     (26081): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:23:27.148+0800 E/AUL     (26081): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:23:27.183+0800 I/UXT     (26081): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:23:27.313+0800 E/MALI    (26081): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 18:23:27.313+0800 E/MALI    (26081): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 18:23:27.313+0800 E/MALI    (26081): [gpu-ddk] devel/graphics_drv/r4p0
07-10 18:23:27.313+0800 E/MALI    (26081): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 18:23:27.313+0800 E/MALI    (26081): [coregl] devel/graphics_engine/master
07-10 18:23:27.313+0800 E/MALI    (26081): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 18:23:27.738+0800 E/rpm-installer(26069): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-10 18:23:27.738+0800 E/rpm-installer(26069): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-10 18:23:27.738+0800 E/rpm-installer(26069): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-10 18:23:27.763+0800 E/PKGMGR_SERVER(26068): pkgmgr-server.c: sighandler(486) > child NORMAL exit [26069]
07-10 18:23:28.258+0800 I/MALI    (26081): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-10 18:23:28.258+0800 E/MALI    (26081): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-10 18:23:28.288+0800 I/AUL     (26090): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-10 18:23:28.303+0800 I/AUL     (26090): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:23:28.303+0800 E/AUL     (26090): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:23:28.303+0800 E/AUL     (26090): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:23:28.583+0800 E/PKGMGR_SERVER(26068): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-10 18:23:28.588+0800 E/PKGMGR_SERVER(26068): pkgmgr-server.c: main(2296) > package manager server terminated.
07-10 18:23:30.383+0800 W/AUL     (26170): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 18:23:30.388+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 18:23:30.423+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-10 18:23:30.448+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-10 18:23:30.448+0800 E/AUL_AMD (  518): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-10 18:23:30.448+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 26170
07-10 18:23:30.468+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 18:23:30.473+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 18:23:30.473+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 18:23:30.473+0800 W/AUL_PAD (26079): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 18:23:30.478+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 18:23:30.478+0800 W/AUL_PAD (26079): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 18:23:30.478+0800 W/AUL_PAD (26079): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 18:23:30.478+0800 W/AUL_PAD (26079): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 18:23:30.543+0800 I/efl-extension(26079): efl_extension.c: eext_mod_init(40) > Init
07-10 18:23:30.548+0800 I/UXT     (26079): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:23:30.548+0800 W/AUL_PAD (26079): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 18:23:30.548+0800 W/AUL_PAD (26079): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 18:23:30.548+0800 I/CAPI_APPFW_APPLICATION(26079): app_main.c: ui_app_main(704) > app_efl_main
07-10 18:23:30.553+0800 I/CAPI_APPFW_APPLICATION(26079): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 18:23:30.573+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(26079) type(uiapp) bg(0)
07-10 18:23:30.573+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (26079) was created
07-10 18:23:30.573+0800 W/AUL     (26170): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26079)
07-10 18:23:30.603+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26079]
07-10 18:23:30.753+0800 I/efl-extension(26079): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 18:23:30.753+0800 I/efl-extension(26079): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 18:23:30.753+0800 I/efl-extension(26079): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 18:23:30.753+0800 I/efl-extension(26079): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 18:23:30.753+0800 I/efl-extension(26079): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44416a10, elm_image, _activated_obj : 0x0, activated : 1
07-10 18:23:30.758+0800 E/EFL     (26079): elementary<26079> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 18:23:30.763+0800 E/EFL     (26079): elementary<26079> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44416e78) will be pushed
07-10 18:23:30.763+0800 I/efl-extension(26079): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x418a1330]'s widget[0x44418308] to layout widget[0x44416e78]
07-10 18:23:30.768+0800 E/EFL     (26079): elementary<26079> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e7d58 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:23:30.768+0800 E/EFL     (26079): elementary<26079> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e7d58 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 18:23:30.768+0800 I/efl-extension(26079): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 18:23:31.108+0800 W/CRASH_MANAGER(26172): worker.c: worker_job(1205) > 112607973656e1499682210
07-10 18:23:31.578+0800 W/AUL_AMD (  518): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-10 18:23:31.578+0800 W/AUL_AMD (  518): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
07-10 18:23:31.738+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 26079 pgid = 26079
07-10 18:23:31.738+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-10 18:23:31.743+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 18:23:31.743+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 18:23:31.743+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(26079), proc(0)
07-10 18:23:31.743+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 18:23:31.743+0800 E/AUL     ( 1110): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 18:23:31.743+0800 E/CAPI_APPFW_APP_MANAGER( 1110): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 18:23:31.758+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __read_proc(55) > file open error : 2
07-10 18:23:31.758+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
07-10 18:23:31.758+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(26079), proc(0)
07-10 18:23:31.758+0800 E/AUL     (  950): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
07-10 18:23:31.758+0800 E/CAPI_APPFW_APP_MANAGER(  950): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
07-10 18:23:31.763+0800 E/SECURITY_EXTENSION_SERVER(  481): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
07-10 18:23:31.823+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-10 18:23:31.828+0800 I/AUL_AMD (  518): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26079
07-10 18:23:31.828+0800 W/AUL     (  518): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26079)
07-10 18:23:32.038+0800 I/AUL_PAD (26184): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-10 18:23:35.378+0800 W/KEYROUTER(  469): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x2e00003
07-10 18:23:35.378+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=9117791
07-10 18:23:35.558+0800 W/KEYROUTER(  469): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x2e00003
07-10 18:23:35.558+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=9117975
07-10 18:23:35.558+0800 W/APPS    (  824): AppsViewNecklace.cpp: onEdit(1180) >  Changed to edit mode[0]
07-10 18:23:35.558+0800 W/W_HOME  (  824): event_manager.c: _apptray_visibility_cb(604) > apps,edit,hide
07-10 18:23:35.558+0800 W/W_HOME  (  824): event_manager.c: _apptray_visibility_cb(624) > state: 0 -> 1
07-10 18:23:35.563+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:23:35.563+0800 W/W_INDICATOR(  760): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-10 18:23:35.563+0800 W/W_INDICATOR(  760): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-10 18:23:35.563+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:23:35.563+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:23:35.563+0800 W/W_HOME  (  824): win.c: win_back_gesture_disable_set(170) > disable back gesture
07-10 18:23:35.563+0800 W/W_HOME  (  824): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-10 18:23:35.563+0800 W/W_HOME  (  824): noti_broker.c: _apptray_visibility_cb(786) > apps,edit,hide
07-10 18:23:35.563+0800 W/APPS    (  824): AppsViewNecklace.cpp: onBubbleButtonEffect(2422) >  [249, 249, 249, 255]
07-10 18:23:35.568+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 18:23:35.573+0800 W/APPS    (  824): AppsItem.cpp: aniFocusIndex(2351) >  [sensoraccelerator:31] Focused[0], focusIdx[31]
07-10 18:23:35.573+0800 W/W_HOME  (  824): key.c: _execute_cbs(123) > back key execution has been stopped
07-10 18:23:36.143+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:23:36.148+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:23:36.148+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9118562
07-10 18:23:36.148+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:36.503+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:23:36.503+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9118922
07-10 18:23:36.503+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:36.508+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:23:36.843+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:23:36.843+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9119263
07-10 18:23:36.843+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:36.848+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:23:37.133+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:37.138+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:37.138+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9119553
07-10 18:23:37.138+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:37.248+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:37.248+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9119668
07-10 18:23:37.248+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:37.253+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:37.423+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:37.423+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:37.423+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9119841
07-10 18:23:37.423+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:37.763+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:23:37.763+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9120179
07-10 18:23:37.763+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:37.763+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-10 18:23:38.313+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:38.313+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:38.313+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9120732
07-10 18:23:38.313+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:38.398+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:38.398+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:38.398+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9120814
07-10 18:23:38.398+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:38.468+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:38.468+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:38.468+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9120887
07-10 18:23:38.468+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:38.943+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=9121361 button=1
07-10 18:23:38.943+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [97, 96]
07-10 18:23:38.948+0800 E/W_HOME  (  824): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-10 18:23:39.043+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=9121457 button=1
07-10 18:23:39.043+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [97, 96]->[96, 102]
07-10 18:23:39.043+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[32], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:23:39.043+0800 W/APPS    (  824): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[32]
07-10 18:23:39.048+0800 W/APPS    (  824): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-10 18:23:39.048+0800 W/APPS    (  824): AppsItem.cpp: aniFocusIndex(2351) >  [sensordatacollection:32] Focused[0], focusIdx[32]
07-10 18:23:39.048+0800 W/APPS    (  824): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-10 18:23:39.058+0800 E/APPS    (  824): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(4083) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
07-10 18:23:39.058+0800 E/APPS    (  824): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-10 18:23:39.288+0800 W/APPS    (  824): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-10 18:23:40.043+0800 E/EFL     (  469): ecore_x<469> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2e00003 time=9121457
07-10 18:23:40.043+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=9121457
07-10 18:23:40.043+0800 E/EFL     (  469): ecore_x<469> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=9121457
07-10 18:23:40.558+0800 I/efl-extension( 3159): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:40.558+0800 I/efl-extension(  824): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-10 18:23:40.558+0800 I/efl-extension(  824): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x473287a0, elm_layout, time_stamp : 9122976
07-10 18:23:40.558+0800 W/APPS    (  824): AppsViewNecklace.cpp: onRotary(5352) >  App is moving[0,0,1]
07-10 18:23:53.913+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 18:23:55.433+0800 E/WMS     (  516): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-10 18:24:00.698+0800 W/APPS    (  824): apps_main.c: _time_changed_cb(308) >  date : 10->10
07-10 18:24:12.503+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=9154917 button=1
07-10 18:24:12.503+0800 E/EFL     (  824): ecore_x<824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=9154918 button=1
07-10 18:24:12.503+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [311, 138]
07-10 18:24:12.508+0800 E/W_HOME  (  824): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-10 18:24:12.513+0800 W/APPS    (  824): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [311, 138]->[306, 142]
07-10 18:24:12.513+0800 W/APPS    (  824): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[32], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-10 18:24:12.513+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,32]
07-10 18:24:12.513+0800 E/APPS    (  824): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-10 18:24:12.513+0800 W/APPS    (  824): AppsItem.cpp: onItemClicked(487) >  item(sensordatacollection) launched, open(0), tts(0)
07-10 18:24:12.518+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 18:24:12.518+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 18:24:12.523+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 824
07-10 18:24:12.523+0800 I/AUL_AMD (  518): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-10 18:24:12.533+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 18:24:12.533+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 18:24:12.533+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 18:24:12.538+0800 W/AUL_PAD (26184): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 18:24:12.538+0800 W/AUL_PAD (26184): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 18:24:12.538+0800 W/AUL_PAD (26184): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 18:24:12.538+0800 W/AUL_PAD (26184): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 18:24:12.543+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 18:24:12.593+0800 I/efl-extension(26184): efl_extension.c: eext_mod_init(40) > Init
07-10 18:24:12.598+0800 I/UXT     (26184): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:24:12.598+0800 W/AUL_PAD (26184): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 18:24:12.598+0800 W/AUL_PAD (26184): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 18:24:12.598+0800 I/CAPI_APPFW_APPLICATION(26184): app_main.c: ui_app_main(704) > app_efl_main
07-10 18:24:12.603+0800 I/CAPI_APPFW_APPLICATION(26184): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 18:24:12.638+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(26184) type(uiapp) bg(0)
07-10 18:24:12.638+0800 W/AUL     (  824): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26184)
07-10 18:24:12.638+0800 W/W_HOME  (  824): util.c: apps_util_launch_main_operation(643) > Launch app:[sensordatacollection] ret:[0]
07-10 18:24:12.638+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=9155033 button=1
07-10 18:24:12.638+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (26184) was created
07-10 18:24:12.638+0800 E/AUL     (  518): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-10 18:24:12.648+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26184]
07-10 18:24:12.733+0800 E/EFL     (  518): ecore_x<518> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=9155153 button=1
07-10 18:24:12.778+0800 I/efl-extension(26184): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 18:24:12.778+0800 I/efl-extension(26184): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 18:24:12.778+0800 I/efl-extension(26184): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 18:24:12.778+0800 I/efl-extension(26184): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 18:24:12.778+0800 I/efl-extension(26184): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4189de50, elm_image, _activated_obj : 0x0, activated : 1
07-10 18:24:12.778+0800 E/EFL     (26184): elementary<26184> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 18:24:12.783+0800 E/EFL     (26184): elementary<26184> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4189e2b8) will be pushed
07-10 18:24:12.788+0800 I/efl-extension(26184): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x4188f080]'s widget[0x4189f748] to layout widget[0x4189e2b8]
07-10 18:24:12.788+0800 E/EFL     (26184): elementary<26184> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e7fa8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:24:12.788+0800 E/EFL     (26184): elementary<26184> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e7fa8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 18:24:12.788+0800 I/efl-extension(26184): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 18:24:12.998+0800 W/CRASH_MANAGER(26237): worker.c: worker_job(1205) > 112618473656e149968225
