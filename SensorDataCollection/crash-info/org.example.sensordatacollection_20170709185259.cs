S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 29981
Date: 2017-07-09 18:52:59+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000001
r2   = 0x00000000, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x419377fc
r6   = 0x00000000, r7   = 0xbeed2d30
r8   = 0x00000041, r9   = 0x40458824
r10  = 0x417b6210, fp   = 0x00000000
ip   = 0x404d9b50, sp   = 0xbeed2be8
lr   = 0x414c0bdf, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:     46864 KB
Buffers:     17576 KB
Cached:     122064 KB
VmPeak:     110060 KB
VmSize:     109044 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19568 KB
VmRSS:       19568 KB
VmData:      48380 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23268 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 29981 TID = 29981
29981 30059 30060 30061 30062 

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
418c8000 418d4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418dd000 418fe000 r-xp /usr/lib/libefl-extension.so.0.1.0
41906000 41930000 r-xp /usr/lib/libsensor.so.1.9.5
41939000 41940000 r-xp /usr/lib/libctx-shared.so.0.8.3
41948000 4194d000 r-xp /usr/lib/libctx-client.so.0.8.3
41955000 41967000 r-xp /usr/lib/libefl-assist.so.0.1.0
4196f000 41a27000 r-xp /usr/lib/libcairo.so.2.11200.14
41a32000 41a3c000 r-xp /usr/lib/libsensord-shared.so
41a44000 41a53000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a5c000 41a72000 r-xp /usr/lib/libtts.so
41a7b000 41a9e000 r-xp /usr/lib/libui-extension.so.0.1.0
41aa7000 41ab2000 r-xp /usr/lib/libtbm.so.1.0.0
41aba000 41ac8000 r-xp /usr/lib/libGLESv2.so.2.0
41ad1000 41ad2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41adb000 41ae1000 r-xp /usr/lib/libxcb-render.so.0.0.0
41ae9000 41aec000 r-xp /usr/lib/libEGL.so.1.4
41af4000 41af9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41b01000 41b04000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b0c000 41b0d000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b16000 41c9e000 r-xp /usr/lib/libicui18n.so.57.1
41cae000 41db4000 r-xp /usr/lib/libicuuc.so.57.1
41dca000 41dd2000 r-xp /usr/lib/libdrm.so.2.4.0
41dda000 41ddc000 r-xp /usr/lib/libdri2.so.0.0.0
41de4000 41dea000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41df2000 41df7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41dff000 41e18000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436b9000 436da000 r-xp /usr/lib/libexif.so.12.3.3
436ed000 436ef000 r-xp /usr/lib/libttrace.so.1.1
436f7000 436fc000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43704000 4370a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43713000 4371b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43723000 43745000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4374e000 43755000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4375e000 43760000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43768000 4376f000 r-xp /usr/lib/libminizip.so.1.0.0
43777000 43784000 r-xp /usr/lib/libail.so.0.1.0
4378d000 43793000 r-xp /usr/lib/libproc-stat.so.0.2.96
4379b000 4379c000 r-xp /usr/lib/libresponse.so.0.2.96
437a4000 437a9000 r-xp /usr/lib/libsystem.so.0.0.0
437b3000 4387d000 r-xp /usr/lib/libCOREGL.so.4.0
43c22000 43c2d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c36000 43c3b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c43000 43c5a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c67000 43c69000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44571000 44572000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44636000 44e35000 rw-p [stack:30059]
44e36000 45635000 rw-p [stack:30060]
45636000 45e35000 rw-p [stack:30061]
46001000 46900000 rw-p [stack:30062]
beeb3000 beed4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29981)
Call Stack Count: 17
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: _data_collection + 0x66 (0x414c0bdf) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2bdf
 2: _new_acceleartion_value + 0x8a (0x414c0a57) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2a57
 3: (0x418d1127) [/usr/lib/libcapi-system-sensor.so.0] + 0x9127
 4: (0x4191aaf0) [/usr/lib/libsensor.so.1] + 0x14af0
 5: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 6: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 7: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 8: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
 9: (0x402fe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
10: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x116 (0x414bfb87) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1b87
14: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
15: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
16: create_base_gui + 0x157 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
r( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:49.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:49.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:49.400+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:49.400+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:49.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:49.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:49.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:49.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:50.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:50.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:50.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:50.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:50.390+0800 E/PKGMGR  (29968): pkgmgr.c: pkgmgr_client_install(1651) > install pkg start.
07-09 18:52:50.400+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:50.400+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:50.405+0800 E/PKGMGR_SERVER(29917): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-09 18:52:50.405+0800 E/PKGMGR_SERVER(29917): pkgmgr-server.c: main(2296) > package manager server terminated.
07-09 18:52:50.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:50.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:50.610+0800 E/PKGMGR_SERVER(29970): pkgmgr-server.c: main(2242) > package manager server start
07-09 18:52:50.730+0800 E/PKGMGR  (29970): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk is core
07-09 18:52:50.730+0800 E/PKGMGR  (29970): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk is core
07-09 18:52:50.735+0800 E/rpm-installer(29970): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
07-09 18:52:50.735+0800 E/BACKEND_LIB(29970): librpm.c: __is_symlink_file(70) > file is safe
07-09 18:52:50.750+0800 E/PKGMGR_SERVER(29970): pm-mdm.c: _pm_check_mdm_policy(1063) > [0;31m[_pm_check_mdm_policy(): 1063](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
07-09 18:52:50.755+0800 E/PKGMGR  (29968): pkgmgr.c: pkgmgr_client_install(1768) > install pkg finish, ret=[299680002]
07-09 18:52:50.755+0800 E/PKGMGR_SERVER(29971): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk]
07-09 18:52:50.760+0800 E/PKGMGR_SERVER(29972): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
07-09 18:52:50.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:50.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:50.855+0800 E/rpm-installer(29971): rpm-appcore-intf.c: main(120) > ------------------------------------------------
07-09 18:52:50.855+0800 E/rpm-installer(29971): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
07-09 18:52:50.855+0800 E/rpm-installer(29971): rpm-appcore-intf.c: main(122) > ------------------------------------------------
07-09 18:52:50.895+0800 E/PKGMGR_OBSERVER(29972): pkg_observer.c: main(601) > OBSERVER start
07-09 18:52:51.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:51.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:51.010+0800 E/rpm-installer(29971): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.sensordatacollection-1.0.0-arm.tpk] is tpk package.
07-09 18:52:51.015+0800 E/rpm-installer(29971): coretpk-parser.c: __coretpk_parser_get_value(1713) > (result_value == NULL) [install-location] is empty.
07-09 18:52:51.015+0800 E/rpm-installer(29971): coretpk-parser.c: __coretpk_parser_get_value_list(1670) > (ret == 1) [//*[name() ='privileges']/*[name()='privilege']] is empty.
07-09 18:52:51.015+0800 E/rpm-installer(29971): coretpk-parser.c: _coretpk_parser_is_widget(1586) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget'])
07-09 18:52:51.015+0800 E/rpm-installer(29971): coretpk-parser.c: _coretpk_parser_is_custom_clock(1480) > (ret == 1) metadata(watchface) is empty.
07-09 18:52:51.020+0800 E/rpm-installer(29971): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.sensordatacollection/) failed. [2][No such file or directory]
07-09 18:52:51.020+0800 E/rpm-installer(29971): coretpk-installer.c: _coretpk_installer_install_package(3579) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.sensordatacollection/]
07-09 18:52:51.115+0800 E/PKGMGR_OBSERVER(29972): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[299720002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[start] val[install]
07-09 18:52:51.130+0800 E/APPS    (  982): pkgmgr.c: _start(495) >  (_exist_request_in_list(package)) -> _start() return
07-09 18:52:51.130+0800 E/APPS    (  982): pkgmgr.c: _pkgmgr_cb(840) >  pkgmgr_cbs[0].func has errors.
07-09 18:52:51.135+0800 W/AUL_AMD (  527): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(start), value(install)
07-09 18:52:51.140+0800 E/PKGMGR_OBSERVER(29972): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[299720002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[30]
07-09 18:52:51.160+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, STARTED]
07-09 18:52:51.180+0800 E/PKGMGR  (12796): pkgmgr.c: __find_op_cbinfo(417) > tmp is NULL
07-09 18:52:51.180+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-09 18:52:51.195+0800 E/PKGMGR  (12796): pkgmgr.c: __find_op_cbinfo(417) > tmp is NULL
07-09 18:52:51.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:51.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:51.300+0800 W/CERT_SVC(29971): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
07-09 18:52:51.315+0800 E/rpm-installer(29971): coretpk-parser.c: __coretpk_parser_verify_metadata(48) > (ret == 1) metadata is empty.
07-09 18:52:51.320+0800 E/rpm-installer(29971): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
07-09 18:52:51.320+0800 E/rpm-installer(29971): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
07-09 18:52:51.320+0800 E/rpm-installer(29971): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
07-09 18:52:51.365+0800 E/PKGMGR_PARSER(29971): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
07-09 18:52:51.365+0800 E/PKGMGR_PARSER(29971): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/org.example.sensordatacollection.xml
07-09 18:52:51.370+0800 E/PKGMGR_PARSER(29971): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
07-09 18:52:51.370+0800 E/PKGMGR_PARSER(29971): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
07-09 18:52:51.400+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:51.400+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:51.550+0800 I/efl-extension(29971): efl_extension.c: eext_mod_init(40) > Init
07-09 18:52:51.555+0800 I/efl-extension(29971): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-09 18:52:51.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:51.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:51.640+0800 E/PKGMGR_PARSER(29971): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
07-09 18:52:51.680+0800 E/PKGMGR_CERT(29971): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
07-09 18:52:51.685+0800 E/PKGMGR_CERT(29971): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 120
07-09 18:52:51.685+0800 E/PKGMGR_CERT(29971): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 120
07-09 18:52:51.685+0800 E/PKGMGR_CERT(29971): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 29 6
07-09 18:52:51.685+0800 E/PKGMGR_CERT(29971): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 21 14
07-09 18:52:51.685+0800 E/PKGMGR_CERT(29971): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 14
07-09 18:52:51.685+0800 E/PKGMGR_CERT(29971): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 30 6
07-09 18:52:51.700+0800 E/PKGMGR_CERT(29971): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
07-09 18:52:51.710+0800 E/PKGMGR_OBSERVER(29972): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[299720002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[60]
07-09 18:52:51.745+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-09 18:52:51.770+0800 E/rpm-installer(29971): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
07-09 18:52:51.780+0800 E/rpm-installer(29971): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [z0QlgvtZWc7MUAsAHX1kZCd6NyfN6kalPinZVqoqrqE=] for shared/trusted.
07-09 18:52:51.790+0800 E/PKGMGR  (12796): pkgmgr.c: __find_op_cbinfo(417) > tmp is NULL
07-09 18:52:51.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:51.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:51.815+0800 E/rpm-installer(29971): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
07-09 18:52:51.820+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 29632 pgid = 29632
07-09 18:52:51.820+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-09 18:52:51.825+0800 E/PKGMGR_OBSERVER(29972): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[299720002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[install_percent] val[100]
07-09 18:52:51.905+0800 E/rpm-installer(29971): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
07-09 18:52:51.915+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
07-09 18:52:51.970+0800 I/AUL_AMD (  527): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29632
07-09 18:52:51.970+0800 W/AUL     (  527): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29632)
07-09 18:52:52.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:52.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:52.050+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-09 18:52:52.050+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 29612 pgid = -1
07-09 18:52:52.050+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-09 18:52:52.050+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-09 18:52:52.055+0800 I/AUL_AMD (  527): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29612
07-09 18:52:52.055+0800 W/AUL     (  527): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29612)
07-09 18:52:52.070+0800 E/PKGMGR  (12796): pkgmgr.c: __find_op_cbinfo(417) > tmp is NULL
07-09 18:52:52.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:52.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:52.330+0800 I/AUL_AMD (  527): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29172
07-09 18:52:52.330+0800 W/AUL     (  527): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29172)
07-09 18:52:52.400+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:52.400+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:52.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:52.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:52.675+0800 I/AUL_PAD (29981): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-09 18:52:52.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:52.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:53.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:53.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:53.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:53.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:53.400+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:53.400+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:53.405+0800 E/PKGMGR_SERVER(29970): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-09 18:52:53.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:53.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:53.775+0800 W/MM_CAMCORDER(29982): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
07-09 18:52:53.775+0800 W/MM_CAMCORDER(29982): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
07-09 18:52:53.780+0800 I/efl-extension(29982): efl_extension.c: eext_mod_init(40) > Init
07-09 18:52:53.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:53.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:54.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:54.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:54.135+0800 I/efl-extension(29983): efl_extension.c: eext_mod_init(40) > Init
07-09 18:52:54.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:54.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:54.235+0800 E/PKGMGR_OBSERVER(29972): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[299720002] pkg_type[tpk] pkgid[org.example.sensordatacollection] key[end] val[ok]
07-09 18:52:54.250+0800 W/W_HOME  (  982): clock_event.c: _pkgmgr_event_cb(247) > Pkg:org.example.sensordatacollection is updated, need to check validation
07-09 18:52:54.250+0800 W/W_HOME  (  982): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.watchface
07-09 18:52:54.285+0800 E/PKGMGR  (12796): pkgmgr.c: __find_op_cbinfo(417) > tmp is NULL
07-09 18:52:54.285+0800 W/AUL_AMD (  527): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(ok)
07-09 18:52:54.335+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, COMPLETED]
07-09 18:52:54.335+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-09 18:52:54.335+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-09 18:52:54.335+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-09 18:52:54.335+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-09 18:52:54.400+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:54.400+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:54.410+0800 E/STARTER (  866): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-09 18:52:54.425+0800 E/WMS     (  522): wms_db.c: wms_db_package_event_insert_record(190) > 
07-09 18:52:54.435+0800 E/PKGMGR_INFO(29972): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-09 18:52:54.445+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-09 18:52:54.465+0800 E/PKGMGR_INFO(  521): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-09 18:52:54.475+0800 E/PKGMGR_OBSERVER(29972): pkg_observer.c: main(620) > OBSERVER end
07-09 18:52:54.490+0800 E/PKGMGR_SERVER(29970): pkgmgr-server.c: sighandler(486) > child NORMAL exit [29972]
07-09 18:52:54.490+0800 W/APPS    (  982): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-09 18:52:54.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:54.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:54.645+0800 I/UXT     (29983): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-09 18:52:54.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:54.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:55.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:55.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:55.085+0800 I/AUL_PAD (29983): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-09 18:52:55.185+0800 E/MALI    (29983): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-09 18:52:55.185+0800 E/MALI    (29983): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-09 18:52:55.185+0800 E/MALI    (29983): [gpu-ddk] devel/graphics_drv/r4p0
07-09 18:52:55.185+0800 E/MALI    (29983): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-09 18:52:55.185+0800 E/MALI    (29983): [coregl] devel/graphics_engine/master
07-09 18:52:55.185+0800 E/MALI    (29983): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-09 18:52:55.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:55.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:55.400+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:55.400+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:55.405+0800 E/PKGMGR_SERVER(29970): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-09 18:52:55.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:55.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:55.635+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.650+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.650+0800 E/AUL     (29982): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-09 18:52:55.650+0800 E/AUL     (29982): aul_path.c: __get_path(169) > root_path is NULL!
07-09 18:52:55.675+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.685+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.690+0800 E/AUL     (29982): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-09 18:52:55.690+0800 E/AUL     (29982): aul_path.c: __get_path(169) > root_path is NULL!
07-09 18:52:55.700+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.710+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.710+0800 E/AUL     (29982): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-09 18:52:55.710+0800 E/AUL     (29982): aul_path.c: __get_path(169) > root_path is NULL!
07-09 18:52:55.720+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.730+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.730+0800 E/AUL     (29982): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-09 18:52:55.730+0800 E/AUL     (29982): aul_path.c: __get_path(169) > root_path is NULL!
07-09 18:52:55.740+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.755+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.755+0800 E/AUL     (29982): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-09 18:52:55.755+0800 E/AUL     (29982): aul_path.c: __get_path(169) > root_path is NULL!
07-09 18:52:55.765+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.775+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.775+0800 E/AUL     (29982): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-09 18:52:55.775+0800 E/AUL     (29982): aul_path.c: __get_path(169) > root_path is NULL!
07-09 18:52:55.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:55.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:55.815+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.845+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.845+0800 E/AUL     (29982): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-09 18:52:55.845+0800 E/AUL     (29982): aul_path.c: __get_path(169) > root_path is NULL!
07-09 18:52:55.855+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.880+0800 I/AUL     (29982): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:55.880+0800 E/AUL     (29982): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-09 18:52:55.880+0800 E/AUL     (29982): aul_path.c: __get_path(169) > root_path is NULL!
07-09 18:52:55.905+0800 I/UXT     (29982): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-09 18:52:56.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:56.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:56.050+0800 E/MALI    (29982): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-09 18:52:56.055+0800 E/MALI    (29982): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-09 18:52:56.055+0800 E/MALI    (29982): [gpu-ddk] devel/graphics_drv/r4p0
07-09 18:52:56.055+0800 E/MALI    (29982): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-09 18:52:56.055+0800 E/MALI    (29982): [coregl] devel/graphics_engine/master
07-09 18:52:56.055+0800 E/MALI    (29982): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-09 18:52:56.055+0800 E/MALI    (29982): CHK��
07-09 18:52:56.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:56.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:56.400+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:56.400+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:56.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:56.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:56.650+0800 E/rpm-installer(29971): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-09 18:52:56.650+0800 E/rpm-installer(29971): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-09 18:52:56.650+0800 E/rpm-installer(29971): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-09 18:52:56.705+0800 E/PKGMGR_SERVER(29970): pkgmgr-server.c: sighandler(486) > child NORMAL exit [29971]
07-09 18:52:56.705+0800 E/RESOURCED(  627): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/29971/oom_score_adj failed
07-09 18:52:56.705+0800 E/RESOURCED(  627): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 29971
07-09 18:52:56.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:56.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:57.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:57.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:57.085+0800 I/MALI    (29982): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-09 18:52:57.085+0800 E/MALI    (29982): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-09 18:52:57.110+0800 I/AUL     (29992): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-09 18:52:57.125+0800 I/AUL     (29992): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-09 18:52:57.125+0800 E/AUL     (29992): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-09 18:52:57.125+0800 E/AUL     (29992): aul_path.c: __get_path(169) > root_path is NULL!
07-09 18:52:57.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:57.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:57.405+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:57.405+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:57.405+0800 E/PKGMGR_SERVER(29970): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-09 18:52:57.405+0800 E/PKGMGR_SERVER(29970): pkgmgr-server.c: main(2296) > package manager server terminated.
07-09 18:52:57.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:57.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:57.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:57.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:58.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:58.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:58.205+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:58.205+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:58.405+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:58.405+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:58.610+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:58.610+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:58.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:58.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:58.970+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-09 18:52:59.000+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:59.000+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:59.200+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:59.200+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:59.210+0800 W/AUL     (30051): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-09 18:52:59.215+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 0
07-09 18:52:59.250+0800 I/AUL_AMD (  527): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-09 18:52:59.275+0800 I/AUL_AMD (  527): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-09 18:52:59.275+0800 E/AUL_AMD (  527): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-09 18:52:59.275+0800 W/AUL_AMD (  527): amd_launch.c: _start_app(1782) > caller pid : 30051
07-09 18:52:59.295+0800 E/RESOURCED(  627): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 8
07-09 18:52:59.295+0800 W/AUL_AMD (  527): amd_launch.c: _start_app(2218) > pad pid(-5)
07-09 18:52:59.295+0800 W/AUL_PAD ( 1157): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-09 18:52:59.295+0800 W/AUL_PAD ( 1157): launchpad.c: __send_result_to_caller(272) > Check app launching
07-09 18:52:59.300+0800 W/AUL_PAD (29981): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-09 18:52:59.300+0800 W/AUL_PAD (29981): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-09 18:52:59.300+0800 W/AUL_PAD (29981): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-09 18:52:59.300+0800 W/AUL_PAD (29981): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-09 18:52:59.360+0800 I/efl-extension(29981): efl_extension.c: eext_mod_init(40) > Init
07-09 18:52:59.365+0800 I/UXT     (29981): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-09 18:52:59.370+0800 W/AUL_PAD (29981): launchpad_loader.c: main(690) > [candidate] dlsym
07-09 18:52:59.370+0800 W/AUL_PAD (29981): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-09 18:52:59.370+0800 I/CAPI_APPFW_APPLICATION(29981): app_main.c: ui_app_main(704) > app_efl_main
07-09 18:52:59.375+0800 I/CAPI_APPFW_APPLICATION(29981): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-09 18:52:59.395+0800 W/AUL     (  527): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(29981) type(uiapp) bg(0)
07-09 18:52:59.400+0800 W/AUL     (30051): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29981)
07-09 18:52:59.400+0800 W/AUL_AMD (  527): amd_status.c: __socket_monitor_cb(1277) > (29981) was created
07-09 18:52:59.400+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:59.400+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:59.435+0800 W/STARTER (  866): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [29981]
07-09 18:52:59.590+0800 I/efl-extension(29981): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-09 18:52:59.590+0800 I/efl-extension(29981): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-09 18:52:59.590+0800 I/efl-extension(29981): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-09 18:52:59.590+0800 I/efl-extension(29981): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-09 18:52:59.590+0800 I/efl-extension(29981): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4189ef90, elm_image, _activated_obj : 0x0, activated : 1
07-09 18:52:59.590+0800 E/EFL     (29981): elementary<29981> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-09 18:52:59.600+0800 E/EFL     (29981): elementary<29981> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4189f3f8) will be pushed
07-09 18:52:59.600+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:59.600+0800 I/efl-extension(29981): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x4188e350]'s widget[0x418a0888] to layout widget[0x4189f3f8]
07-09 18:52:59.600+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:59.600+0800 E/EFL     (29981): elementary<29981> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9340 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 18:52:59.600+0800 E/EFL     (29981): elementary<29981> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9340 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-09 18:52:59.600+0800 I/efl-extension(29981): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-09 18:52:59.710+0800 I/APP_CORE(29981): appcore-efl.c: __do_app(453) > [APP 29981] Event: RESET State: CREATED
07-09 18:52:59.710+0800 I/CAPI_APPFW_APPLICATION(29981): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-09 18:52:59.735+0800 I/APP_CORE(29981): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-09 18:52:59.735+0800 I/APP_CORE(29981): appcore-efl.c: __do_app(524) > [APP 29981] Initial Launching, call the resume_cb
07-09 18:52:59.735+0800 I/CAPI_APPFW_APPLICATION(29981): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-09 18:52:59.740+0800 W/W_HOME  (  982): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-09 18:52:59.740+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 18:52:59.740+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 18:52:59.745+0800 W/W_INDICATOR(  867): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-09 18:52:59.745+0800 W/W_INDICATOR(  867): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-09 18:52:59.745+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 18:52:59.745+0800 W/W_HOME  (  982): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-09 18:52:59.755+0800 W/APP_CORE(29981): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1000002
07-09 18:52:59.765+0800 E/EFL     (29981): elementary<29981> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9340 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 18:52:59.765+0800 E/EFL     (29981): elementary<29981> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9340 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-09 18:52:59.800+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:52:59.800+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:52:59.810+0800 E/EFL     (29981): elementary<29981> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9340 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-09 18:52:59.810+0800 E/EFL     (29981): elementary<29981> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9340 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-09 18:52:59.835+0800 I/MALI    (  982): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-09 18:52:59.905+0800 W/W_HOME  (  982): event_manager.c: _window_visibility_cb(466) > Window [0x3600003] is now visible(1)
07-09 18:52:59.905+0800 W/W_HOME  (  982): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-09 18:52:59.905+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 18:52:59.910+0800 W/W_HOME  (  982): event_manager.c: _state_control(326) > appcore paused manually
07-09 18:52:59.910+0800 W/W_HOME  (  982): main.c: home_appcore_pause(514) > Home Appcore Paused
07-09 18:52:59.910+0800 W/W_HOME  (  982): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-09 18:52:59.910+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 18:52:59.910+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 18:52:59.910+0800 W/W_HOME  (  982): main.c: home_pause(546) > clock/widget paused
07-09 18:52:59.910+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-09 18:52:59.910+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:52:59.910+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-09 18:52:59.910+0800 W/W_HOME  (  982): main.c: _window_visibility_cb(963) > Window [0x3600003] is now visible(1)
07-09 18:52:59.915+0800 I/APP_CORE(  982): appcore-efl.c: __do_app(453) > [APP 982] Event: PAUSE State: RUNNING
07-09 18:52:59.915+0800 I/CAPI_APPFW_APPLICATION(  982): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-09 18:52:59.915+0800 W/W_HOME  (  982): main.c: _appcore_pause_cb(487) > appcore pause
07-09 18:52:59.915+0800 E/W_HOME  (  982): main.c: _pause_cb(465) > paused already
07-09 18:52:59.915+0800 I/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-09 18:52:59.915+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 18:52:59.915+0800 W/wnotib  (  982): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [5], notiboard card appending count [6].
07-09 18:52:59.920+0800 W/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[982] goes to (4)
07-09 18:52:59.920+0800 E/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 982)'s state(4)
07-09 18:52:59.920+0800 W/AUL     (  527): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(982) status(bg) type(uiapp)
07-09 18:52:59.920+0800 W/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[29981] goes to (3)
07-09 18:52:59.920+0800 W/AUL_AMD (  527): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-09 18:52:59.920+0800 W/AUL_AMD (  527): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-09 18:52:59.920+0800 W/AUL     (  527): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(29981) status(fg) type(uiapp)
07-09 18:52:59.940+0800 W/WATCH_CORE( 1194): appcore-watch.c: __widget_pause(1113) > widget_pause
07-09 18:52:59.940+0800 W/AUL     ( 1194): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(1194) status(bg) type(watchapp)
07-09 18:52:59.940+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppPause(589) > 
07-09 18:52:59.945+0800 I/APP_CORE(29981): appcore-efl.c: __do_app(453) > [APP 29981] Event: RESUME State: RUNNING
07-09 18:52:59.950+0800 E/CAPI_APPFW_APP_CONTROL( 1326): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-09 18:52:59.950+0800 W/MUSIC_CONTROL_SERVICE( 1326): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1326]   [com.samsung.w-home]register msg port [false][0m
07-09 18:52:59.955+0800 W/W_INDICATOR(  867): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-09 18:52:59.955+0800 W/W_INDICATOR(  867): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-09 18:53:00.290+0800 W/CRASH_MANAGER(30065): worker.c: worker_job(1205) > 112998173656e149959757
