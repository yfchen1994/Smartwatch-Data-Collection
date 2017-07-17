S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 18504
Date: 2017-07-16 19:00:35+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18504, uid 5000)

Register Information
r0   = 0x44dc6530, r1   = 0x413c1bee
r2   = 0x00000025, r3   = 0x9876123a
r4   = 0x44778240, r5   = 0x44dc6530
r6   = 0xbee90b08, r7   = 0x405ab000
r8   = 0x00000000, r9   = 0x40458824
r10  = 0x413c1bee, fp   = 0xbee90af4
ip   = 0x413c1bee, sp   = 0xbee90588
lr   = 0x404baf50, pc   = 0x404baf74
cpsr = 0x00000010

Memory Information
MemTotal:   490112 KB
MemFree:      5180 KB
Buffers:     32196 KB
Cached:     140044 KB
VmPeak:     109060 KB
VmSize:     107024 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24856 KB
VmRSS:       24852 KB
VmData:      43480 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 18504 TID = 18504
18504 18586 18602 18603 18604 

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
416c5000 416c6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
416ce000 4177d000 rw-p [heap]
4177d000 41782000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
4178a000 41796000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418a7000 418c8000 r-xp /usr/lib/libefl-extension.so.0.1.0
418d0000 418d5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
418dd000 41907000 r-xp /usr/lib/libsensor.so.1.9.5
41910000 41917000 r-xp /usr/lib/libctx-shared.so.0.8.3
4191f000 41924000 r-xp /usr/lib/libctx-client.so.0.8.3
4192c000 4193e000 r-xp /usr/lib/libefl-assist.so.0.1.0
41946000 419fe000 r-xp /usr/lib/libcairo.so.2.11200.14
41a09000 41a13000 r-xp /usr/lib/libsensord-shared.so
41a1b000 41a2a000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a33000 41a49000 r-xp /usr/lib/libtts.so
41a52000 41a75000 r-xp /usr/lib/libui-extension.so.0.1.0
41a7e000 41a89000 r-xp /usr/lib/libtbm.so.1.0.0
41a91000 41a9f000 r-xp /usr/lib/libGLESv2.so.2.0
41aa8000 41aa9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41ab2000 41ab8000 r-xp /usr/lib/libxcb-render.so.0.0.0
41ac0000 41ac3000 r-xp /usr/lib/libEGL.so.1.4
41acb000 41ace000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41ad6000 41ad7000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41ae0000 41c68000 r-xp /usr/lib/libicui18n.so.57.1
41c78000 41d7e000 r-xp /usr/lib/libicuuc.so.57.1
41d94000 41d9c000 r-xp /usr/lib/libdrm.so.2.4.0
41da4000 41da6000 r-xp /usr/lib/libdri2.so.0.0.0
41dae000 41db4000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41dbc000 41dc1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41dc9000 41de2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43683000 436a4000 r-xp /usr/lib/libexif.so.12.3.3
436b7000 436b9000 r-xp /usr/lib/libttrace.so.1.1
436c1000 436c6000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
436ce000 436d4000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
436dd000 436e5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
436ed000 4370f000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43718000 4371f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43728000 4372a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43732000 43739000 r-xp /usr/lib/libminizip.so.1.0.0
43741000 4374e000 r-xp /usr/lib/libail.so.0.1.0
43757000 4375d000 r-xp /usr/lib/libproc-stat.so.0.2.96
43765000 43766000 r-xp /usr/lib/libresponse.so.0.2.96
4376e000 43773000 r-xp /usr/lib/libsystem.so.0.0.0
4377d000 43847000 r-xp /usr/lib/libCOREGL.so.4.0
43bec000 43bf7000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c00000 43c05000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c0d000 43c24000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c31000 43c33000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c3c000 444ba000 rw-p [stack:18586]
444c8000 444c9000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444e7000 444ef000 r-xp /usr/lib/libfeedback.so.0.1.4
444f1000 444f2000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44a8c000 44a8e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44a96000 44aa1000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44aa9000 44ab0000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44ab8000 44ad0000 r-xp /usr/lib/libmmfsound.so.0.1.0
44ae1000 44ae5000 r-xp /usr/lib/libmmfsession.so.0.0.0
44aee000 44af9000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44b06000 44b0a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44b12000 44b28000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44b30000 44b91000 r-xp /usr/lib/libasound.so.2.0.0
44b9b000 44b9e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44ba6000 44bde000 r-xp /usr/lib/libpulse.so.0.16.2
44bdf000 44be2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44bea000 44c32000 r-xp /usr/lib/libmdm.so.1.2.62
44c33000 44c36000 r-xp /usr/lib/libtinycompress.so.0.0.0
44c3e000 44c43000 r-xp /usr/lib/libjson.so.0.0.1
44c4b000 44c94000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44c9d000 44ce4000 r-xp /usr/lib/libsndfile.so.1.0.26
44cf0000 44cff000 r-xp /usr/lib/libmdm-common.so.1.1.22
44d08000 44d2a000 r-xp /usr/lib/libvorbis.so.0.4.3
44d32000 44d36000 r-xp /usr/lib/libogg.so.0.7.1
450be000 458bd000 rw-p [stack:18602]
458be000 460bd000 rw-p [stack:18603]
460be000 46a50000 rw-p [stack:18604]
bee71000 bee92000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18504)
Call Stack Count: 18
 0: _IO_vfprintf + 0xa4 (0x404baf74) [/lib/libc.so.6] + 0x3df74
 1: _IO_fprintf + 0x1c (0x404c4478) [/lib/libc.so.6] + 0x47478
 2: _data_collection + 0x2a (0x413c16cb) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x36cb
 3: _new_gyroscope_value + 0x86 (0x413c17f3) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x37f3
 4: (0x41793127) [/usr/lib/libcapi-system-sensor.so.0] + 0x9127
 5: (0x418f1af0) [/usr/lib/libsensor.so.1] + 0x14af0
 6: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 7: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 8: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 9: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
10: (0x402fe4d5) [/usr/lib/libecore.so.1] + 0xc4d5
11: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x11a (0x413c0293) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2293
15: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
16: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
17: _single_line_entry_cb + 0x13 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
ted, need to check validation
07-16 19:00:03.073+0800 W/W_HOME  (  809): clock_event.c: _pkgmgr_event_cb(251) > attacheck clock:com.samsung.watchface
07-16 19:00:03.103+0800 W/AUL_AMD (  520): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.sensordatacollection), key(end), value(ok)
07-16 19:00:03.133+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, COMPLETED]
07-16 19:00:03.133+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
07-16 19:00:03.133+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
07-16 19:00:03.133+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
07-16 19:00:03.133+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_package_install_event(5061) > triggered from Gear itself.
07-16 19:00:03.143+0800 E/PKGMGR_INFO(18491): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
07-16 19:00:03.168+0800 E/PKGMGR_OBSERVER(18491): pkg_observer.c: main(620) > OBSERVER end
07-16 19:00:03.193+0800 E/PKGMGR_SERVER(18489): pkgmgr-server.c: sighandler(486) > child NORMAL exit [18491]
07-16 19:00:03.198+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:03.198+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:03.218+0800 E/STARTER (  771): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
07-16 19:00:03.238+0800 W/APPS    (  809): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-16 19:00:03.238+0800 E/WMS     (  518): wms_db.c: wms_db_package_event_insert_record(190) > 
07-16 19:00:03.248+0800 E/PKGMGR_INFO(  517): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-16 19:00:03.253+0800 W/SVOICE  ( 4287): DomainAppState.cpp: operator()(64) > [0;32mINFO: Apps info changed. SetUploadSyncCondition[0;m
07-16 19:00:03.253+0800 W/SVOICE  ( 4287): PreferenceKey.cpp: SetUploadSyncCondition(551) > [0;32mINFO: UploadManager need to Sync : 1[0;m
07-16 19:00:03.263+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2887) > send_install_response completed : END
07-16 19:00:03.398+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:03.398+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:03.463+0800 W/MM_CAMCORDER(18503): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
07-16 19:00:03.473+0800 W/MM_CAMCORDER(18503): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
07-16 19:00:03.493+0800 I/efl-extension(18503): efl_extension.c: eext_mod_init(40) > Init
07-16 19:00:03.598+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:03.598+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:03.798+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:03.798+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:03.998+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:03.998+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:04.198+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:04.198+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:04.398+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:04.398+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:04.513+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.553+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.553+0800 E/AUL     (18503): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-16 19:00:04.553+0800 E/AUL     (18503): aul_path.c: __get_path(169) > root_path is NULL!
07-16 19:00:04.578+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.598+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:04.598+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:04.608+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.613+0800 E/AUL     (18503): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-16 19:00:04.613+0800 E/AUL     (18503): aul_path.c: __get_path(169) > root_path is NULL!
07-16 19:00:04.648+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.683+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.683+0800 E/AUL     (18503): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-16 19:00:04.683+0800 E/AUL     (18503): aul_path.c: __get_path(169) > root_path is NULL!
07-16 19:00:04.693+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.708+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.708+0800 E/AUL     (18503): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-16 19:00:04.708+0800 E/AUL     (18503): aul_path.c: __get_path(169) > root_path is NULL!
07-16 19:00:04.718+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.733+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.738+0800 E/AUL     (18503): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-16 19:00:04.738+0800 E/AUL     (18503): aul_path.c: __get_path(169) > root_path is NULL!
07-16 19:00:04.753+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.768+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.768+0800 E/AUL     (18503): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-16 19:00:04.768+0800 E/AUL     (18503): aul_path.c: __get_path(169) > root_path is NULL!
07-16 19:00:04.783+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.798+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:04.798+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:04.798+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.798+0800 E/AUL     (18503): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-16 19:00:04.798+0800 E/AUL     (18503): aul_path.c: __get_path(169) > root_path is NULL!
07-16 19:00:04.808+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.823+0800 I/AUL     (18503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:04.823+0800 E/AUL     (18503): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-16 19:00:04.823+0800 E/AUL     (18503): aul_path.c: __get_path(169) > root_path is NULL!
07-16 19:00:04.878+0800 I/UXT     (18503): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-16 19:00:04.888+0800 E/PKGMGR_SERVER(18489): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-16 19:00:04.998+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:04.998+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:05.013+0800 E/MALI    (18503): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-16 19:00:05.013+0800 E/MALI    (18503): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-16 19:00:05.013+0800 E/MALI    (18503): [gpu-ddk] devel/graphics_drv/r4p0
07-16 19:00:05.013+0800 E/MALI    (18503): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-16 19:00:05.013+0800 E/MALI    (18503): [coregl] devel/graphics_engine/master
07-16 19:00:05.013+0800 E/MALI    (18503): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-16 19:00:05.013+0800 E/MALI    (18503): CHKѩ
07-16 19:00:05.198+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:05.198+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:05.398+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:05.398+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:05.558+0800 E/rpm-installer(18490): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-16 19:00:05.558+0800 E/rpm-installer(18490): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-16 19:00:05.558+0800 E/rpm-installer(18490): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-16 19:00:05.568+0800 E/PKGMGR_SERVER(18489): pkgmgr-server.c: sighandler(486) > child NORMAL exit [18490]
07-16 19:00:05.598+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:05.598+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:05.698+0800 E/RESOURCED(  615): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/18490/oom_score_adj failed
07-16 19:00:05.698+0800 E/RESOURCED(  615): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 18490
07-16 19:00:05.798+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:05.798+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:05.908+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-16 19:00:05.998+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:05.998+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:06.143+0800 I/MALI    (18503): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-16 19:00:06.148+0800 E/MALI    (18503): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-16 19:00:06.158+0800 I/AUL     (18514): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-16 19:00:06.173+0800 I/AUL     (18514): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-16 19:00:06.173+0800 E/AUL     (18514): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-16 19:00:06.173+0800 E/AUL     (18514): aul_path.c: __get_path(169) > root_path is NULL!
07-16 19:00:06.198+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:06.198+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:06.403+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:06.403+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:06.603+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:06.603+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:06.808+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:06.808+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:06.888+0800 E/PKGMGR_SERVER(18489): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-16 19:00:06.888+0800 E/PKGMGR_SERVER(18489): pkgmgr-server.c: main(2296) > package manager server terminated.
07-16 19:00:06.998+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:06.998+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:07.198+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:07.198+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:07.398+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:07.398+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:07.598+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:07.598+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:07.623+0800 W/AUL     (18573): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-16 19:00:07.628+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 0
07-16 19:00:07.668+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-16 19:00:07.688+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-16 19:00:07.688+0800 E/AUL_AMD (  520): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-16 19:00:07.693+0800 W/AUL_AMD (  520): amd_launch.c: _start_app(1782) > caller pid : 18573
07-16 19:00:07.708+0800 W/AUL_AMD (  520): amd_launch.c: _start_app(2218) > pad pid(-5)
07-16 19:00:07.708+0800 W/AUL_PAD ( 1332): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-16 19:00:07.708+0800 W/AUL_PAD ( 1332): launchpad.c: __send_result_to_caller(272) > Check app launching
07-16 19:00:07.708+0800 E/RESOURCED(  615): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-16 19:00:07.713+0800 W/AUL_PAD (18504): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-16 19:00:07.713+0800 W/AUL_PAD (18504): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-16 19:00:07.713+0800 W/AUL_PAD (18504): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-16 19:00:07.718+0800 W/AUL_PAD (18504): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-16 19:00:07.783+0800 I/efl-extension(18504): efl_extension.c: eext_mod_init(40) > Init
07-16 19:00:07.788+0800 I/UXT     (18504): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-16 19:00:07.798+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:07.798+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:07.803+0800 W/AUL_PAD (18504): launchpad_loader.c: main(690) > [candidate] dlsym
07-16 19:00:07.803+0800 W/AUL_PAD (18504): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-16 19:00:07.803+0800 I/CAPI_APPFW_APPLICATION(18504): app_main.c: ui_app_main(704) > app_efl_main
07-16 19:00:07.808+0800 W/AUL     (  520): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(18504) type(uiapp) bg(0)
07-16 19:00:07.813+0800 W/AUL_AMD (  520): amd_status.c: __socket_monitor_cb(1277) > (18504) was created
07-16 19:00:07.813+0800 W/AUL     (18573): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18504)
07-16 19:00:07.813+0800 W/STARTER (  771): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18504]
07-16 19:00:07.818+0800 I/CAPI_APPFW_APPLICATION(18504): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-16 19:00:07.998+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:07.998+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:08.013+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-16 19:00:08.013+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-16 19:00:08.013+0800 I/efl-extension(18504): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-16 19:00:08.018+0800 I/efl-extension(18504): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-16 19:00:08.018+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41844fb8, elm_image, _activated_obj : 0x0, activated : 1
07-16 19:00:08.018+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-16 19:00:08.033+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x41845420) will be pushed
07-16 19:00:08.033+0800 I/efl-extension(18504): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x4187b5e0]'s widget[0x418468b0] to layout widget[0x41845420]
07-16 19:00:08.038+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4182ccd8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-16 19:00:08.038+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4182ccd8 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-16 19:00:08.038+0800 I/efl-extension(18504): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-16 19:00:08.073+0800 I/APP_CORE(18504): appcore-efl.c: __do_app(453) > [APP 18504] Event: RESET State: CREATED
07-16 19:00:08.073+0800 I/CAPI_APPFW_APPLICATION(18504): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-16 19:00:08.098+0800 I/APP_CORE(18504): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-16 19:00:08.103+0800 I/APP_CORE(18504): appcore-efl.c: __do_app(524) > [APP 18504] Initial Launching, call the resume_cb
07-16 19:00:08.103+0800 I/CAPI_APPFW_APPLICATION(18504): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-16 19:00:08.113+0800 W/W_HOME  (  809): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-16 19:00:08.113+0800 W/W_HOME  (  809): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-16 19:00:08.113+0800 W/W_HOME  (  809): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-16 19:00:08.113+0800 W/W_HOME  (  809): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-16 19:00:08.113+0800 W/W_HOME  (  809): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-16 19:00:08.113+0800 W/W_INDICATOR(  772): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-16 19:00:08.113+0800 W/W_INDICATOR(  772): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-16 19:00:08.158+0800 W/APP_CORE(18504): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4200002
07-16 19:00:08.158+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4182ccd8 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-16 19:00:08.163+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4182ccd8 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-16 19:00:08.198+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:08.198+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:08.233+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4182ccd8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-16 19:00:08.233+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4182ccd8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-16 19:00:08.238+0800 I/MALI    (  809): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf228] swap changed from sync to async
07-16 19:00:08.383+0800 W/W_HOME  (  809): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-16 19:00:08.383+0800 W/W_HOME  (  809): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-16 19:00:08.383+0800 W/W_HOME  (  809): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-16 19:00:08.383+0800 W/W_HOME  (  809): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-16 19:00:08.383+0800 W/W_HOME  (  809): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-16 19:00:08.383+0800 I/APP_CORE(  809): appcore-efl.c: __do_app(453) > [APP 809] Event: PAUSE State: RUNNING
07-16 19:00:08.423+0800 I/CAPI_APPFW_APPLICATION(  809): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-16 19:00:08.423+0800 W/W_HOME  (  809): main.c: _appcore_pause_cb(487) > appcore pause
07-16 19:00:08.423+0800 W/W_HOME  (  809): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-16 19:00:08.423+0800 W/W_HOME  (  809): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-16 19:00:08.423+0800 W/W_HOME  (  809): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-16 19:00:08.423+0800 W/W_HOME  (  809): main.c: home_pause(546) > clock/widget paused
07-16 19:00:08.423+0800 W/W_HOME  (  809): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
07-16 19:00:08.423+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-16 19:00:08.423+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-16 19:00:08.423+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-16 19:00:08.423+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-16 19:00:08.423+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-16 19:00:08.423+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-16 19:00:08.423+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-16 19:00:08.423+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-16 19:00:08.393+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(809) status(bg) type(uiapp)
07-16 19:00:08.408+0800 W/STARTER (  771): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[809] goes to (4)
07-16 19:00:08.428+0800 W/W_INDICATOR(  772): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-16 19:00:08.433+0800 E/STARTER (  771): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 809)'s state(4)
07-16 19:00:08.408+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-16 19:00:08.433+0800 W/STARTER (  771): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[18504] goes to (3)
07-16 19:00:08.438+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-16 19:00:08.438+0800 W/AUL_AMD (  520): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-16 19:00:08.438+0800 W/AUL_AMD (  520): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-16 19:00:08.438+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(18504) status(fg) type(uiapp)
07-16 19:00:08.438+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-16 19:00:08.438+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-16 19:00:08.438+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-16 19:00:08.438+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-16 19:00:08.438+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-16 19:00:08.438+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-16 19:00:08.438+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-16 19:00:08.438+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-16 19:00:08.438+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-16 19:00:08.443+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-16 19:00:08.443+0800 E/CAPI_APPFW_APP_CONTROL( 1006): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-16 19:00:08.443+0800 W/MUSIC_CONTROL_SERVICE( 1006): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1006]   [com.samsung.w-home]register msg port [false][0m
07-16 19:00:08.453+0800 I/wnotib  (  809): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-16 19:00:08.453+0800 E/wnotib  (  809): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-16 19:00:08.453+0800 W/wnotib  (  809): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [1].
07-16 19:00:08.453+0800 W/W_INDICATOR(  772): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-16 19:00:08.463+0800 I/APP_CORE(18504): appcore-efl.c: __do_app(453) > [APP 18504] Event: RESUME State: RUNNING
07-16 19:00:08.488+0800 W/WATCH_CORE(  930): appcore-watch.c: __widget_pause(1113) > widget_pause
07-16 19:00:08.488+0800 W/AUL     (  930): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(930) status(bg) type(watchapp)
07-16 19:00:08.488+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppPause(589) > 
07-16 19:00:08.768+0800 E/AUL     (  520): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-16 19:00:08.933+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-16 19:00:08.948+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18504
07-16 19:00:08.948+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-16 19:00:08.953+0800 I/APP_CORE(  809): appcore-efl.c: __do_app(453) > [APP 809] Event: MEM_FLUSH State: PAUSED
07-16 19:00:08.973+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-16 19:00:08.983+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18504
07-16 19:00:08.983+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-16 19:00:09.208+0800 I/AUL_PAD (18575): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-16 19:00:13.473+0800 I/APP_CORE(  809): appcore-efl.c: __do_app(453) > [APP 809] Event: MEM_FLUSH State: PAUSED
07-16 19:00:19.143+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-16 19:00:19.898+0800 E/EFL     (18504): ecore_x<18504> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=67096012 button=1
07-16 19:00:19.898+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4182ccd8 : elm_genlist] mouse move
07-16 19:00:19.903+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4182ccd8 : elm_genlist] mouse move
07-16 19:00:19.903+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4182ccd8 : elm_genlist] hold(0), freeze(0)
07-16 19:00:19.908+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4182ccd8 : elm_genlist] mouse move
07-16 19:00:19.908+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4182ccd8 : elm_genlist] hold(0), freeze(0)
07-16 19:00:19.938+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4182ccd8 : elm_genlist] mouse move
07-16 19:00:19.938+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4182ccd8 : elm_genlist] hold(0), freeze(0)
07-16 19:00:19.953+0800 E/EFL     (18504): ecore_x<18504> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=67096064 button=1
07-16 19:00:19.953+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4182ccd8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-16 19:00:19.953+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4182ccd8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-16 19:00:19.953+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x4182ccd8 : elm_genlist] x(0), y(130)
07-16 19:00:19.953+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x4182ccd8 : elm_genlist] t_in(0.300000), pos_x(0)
07-16 19:00:19.953+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x4182ccd8 : elm_genlist] t_in(0.300000), pos_y(130)
07-16 19:00:19.963+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4182ccd8 : elm_genlist] time(0.057331)
07-16 19:00:19.963+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4182ccd8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-16 19:00:19.963+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4182ccd8 : elm_genlist] time(0.057331)
07-16 19:00:19.963+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4182ccd8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(7)
07-16 19:00:20.228+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4182ccd8 : elm_genlist] time(0.307986)
07-16 19:00:20.228+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4182ccd8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(7)
07-16 19:00:20.228+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4182ccd8 : elm_genlist] time(0.307986)
07-16 19:00:20.228+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4182ccd8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(40)
07-16 19:00:20.268+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4182ccd8 : elm_genlist] time(0.996851)
07-16 19:00:20.268+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x4182ccd8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(40)
07-16 19:00:20.268+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4182ccd8 : elm_genlist] time(0.996851)
07-16 19:00:20.273+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x4182ccd8 : elm_genlist] animation stop!!
07-16 19:00:20.298+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-16 19:00:20.298+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44dc01c0, elm_image, _activated_obj : 0x41844fb8, activated : 1
07-16 19:00:20.298+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-16 19:00:20.318+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dbe460 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-16 19:00:20.318+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dbe460 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-16 19:00:20.338+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-16 19:00:20.348+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44dc90a0) will be pushed
07-16 19:00:20.348+0800 I/efl-extension(18504): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44dee7d8]'s widget[0x44de91d8] to layout widget[0x44dc90a0]
07-16 19:00:20.353+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dbe460 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-16 19:00:20.353+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dbe460 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-16 19:00:20.353+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dbe460 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-16 19:00:20.353+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dbe460 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-16 19:00:20.353+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dbe460 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-16 19:00:20.353+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dbe460 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-16 19:00:20.358+0800 I/efl-extension(18504): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-16 19:00:20.363+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x4182ccd8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-16 19:00:20.398+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2796 _push_transition_cb() item(0x44dc90a0) will transition
07-16 19:00:20.808+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:1193 _on_item_push_finished() item(0x41845420) transition finished
07-16 19:00:20.813+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:1218 _on_item_show_finished() item(0x44dc90a0) transition finished
07-16 19:00:20.963+0800 E/EFL     (  463): ecore_x<463> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x4200002 time=67096482
07-16 19:00:20.968+0800 E/EFL     (18504): ecore_x<18504> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=67096482
07-16 19:00:20.973+0800 E/EFL     (  463): ecore_x<463> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=67096482
07-16 19:00:21.283+0800 E/EFL     (18504): ecore_x<18504> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=67097396 button=1
07-16 19:00:21.328+0800 E/EFL     (18504): ecore_x<18504> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=67097437 button=1
07-16 19:00:25.403+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-16 19:00:25.403+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44dc8078, elm_image, _activated_obj : 0x44dc01c0, activated : 1
07-16 19:00:25.408+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-16 19:00:25.433+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dea200 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-16 19:00:25.433+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dea200 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-16 19:00:25.438+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-16 19:00:25.468+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44785fb8) will be pushed
07-16 19:00:25.468+0800 I/efl-extension(18504): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44e92fb8]'s widget[0x44e93920] to layout widget[0x44785fb8]
07-16 19:00:25.483+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dea200 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-16 19:00:25.483+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dea200 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-16 19:00:25.483+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dea200 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-16 19:00:25.488+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dea200 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-16 19:00:25.488+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44dea200 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-16 19:00:25.488+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44dea200 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-16 19:00:25.493+0800 I/efl-extension(18504): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-16 19:00:25.553+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2796 _push_transition_cb() item(0x44785fb8) will transition
07-16 19:00:25.968+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:1193 _on_item_push_finished() item(0x44dc90a0) transition finished
07-16 19:00:25.968+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:1218 _on_item_show_finished() item(0x44785fb8) transition finished
07-16 19:00:29.388+0800 W/SHealthCommon( 1167): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1500163200000.000000[0;m
07-16 19:00:29.523+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-16 19:00:29.548+0800 I/HealthDataService(  990): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-16 19:00:29.588+0800 I/healthData( 1167): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-16 19:00:34.923+0800 E/RESOURCED(  615): block-monitor.c: block_logging(123) > pid 18504(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/admin/2017-07-16-19-0-0-acc.txt
07-16 19:00:34.943+0800 E/RESOURCED(  615): block-monitor.c: block_logging(123) > pid 18504(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/admin/2017-07-16-19-0-0-gyr.txt
07-16 19:00:35.038+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-16 19:00:35.038+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x44785fb8) will be popped.
07-16 19:00:35.063+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-16 19:00:35.068+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44e93f00, elm_image, _activated_obj : 0x44dc8078, activated : 1
07-16 19:00:35.068+0800 I/efl-extension(18504): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-16 19:00:35.088+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44e947d0 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-16 19:00:35.088+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44e947d0 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-16 19:00:35.088+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-16 19:00:35.108+0800 E/EFL     (18504): elementary<18504> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44eb3728) will be pushed
07-16 19:00:35.113+0800 I/efl-extension(18504): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44ea28b0]'s widget[0x44e9e048] to layout widget[0x44eb3728]
07-16 19:00:35.118+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44e947d0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-16 19:00:35.118+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44e947d0 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-16 19:00:35.118+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44e947d0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-16 19:00:35.118+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44e947d0 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-16 19:00:35.118+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44e947d0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-16 19:00:35.118+0800 E/EFL     (18504): elementary<18504> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44e947d0 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-16 19:00:35.123+0800 I/efl-extension(18504): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-16 19:00:35.523+0800 W/STARTER (  771): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[809] goes to (3)
07-16 19:00:35.523+0800 E/STARTER (  771): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 809)'s state(3)
07-16 19:00:35.523+0800 W/AUL_AMD (  520): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-16 19:00:35.523+0800 W/AUL_AMD (  520): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-16 19:00:35.523+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(809) status(fg) type(uiapp)
07-16 19:00:35.588+0800 W/CRASH_MANAGER(18639): worker.c: worker_job(1205) > 111850473656e150020283
