S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 25706
Date: 2017-07-10 18:21:24+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x413d145c
r2   = 0x413d12b4, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x413c1091
r6   = 0x413c0ee3, r7   = 0xbed9a208
r8   = 0x417fd4fb, r9   = 0x0000646a
r10  = 0x4004e7e8, fp   = 0x00000000
ip   = 0x404d9b50, sp   = 0xbed99f20
lr   = 0x413c0ae9, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      7440 KB
Buffers:     21100 KB
Cached:     126908 KB
VmPeak:      74240 KB
VmSize:      74240 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14852 KB
VmRSS:       14852 KB
VmData:      14244 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23272 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 25706 TID = 25706
25706 25713 

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
4151f000 4152a000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41535000 41541000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
4154a000 4154f000 r-xp /usr/lib/libctx-client.so.0.8.3
41557000 41606000 rw-p [heap]
41899000 418ba000 r-xp /usr/lib/libefl-extension.so.0.1.0
418c2000 418ec000 r-xp /usr/lib/libsensor.so.1.9.5
418f5000 418fc000 r-xp /usr/lib/libctx-shared.so.0.8.3
41904000 41916000 r-xp /usr/lib/libefl-assist.so.0.1.0
4191e000 419d6000 r-xp /usr/lib/libcairo.so.2.11200.14
419e1000 419eb000 r-xp /usr/lib/libsensord-shared.so
419f3000 41a02000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a0b000 41a21000 r-xp /usr/lib/libtts.so
41a2a000 41a4d000 r-xp /usr/lib/libui-extension.so.0.1.0
41a56000 41a61000 r-xp /usr/lib/libtbm.so.1.0.0
41a69000 41a77000 r-xp /usr/lib/libGLESv2.so.2.0
41a80000 41a81000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a8a000 41a90000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a98000 41a9b000 r-xp /usr/lib/libEGL.so.1.4
41aa3000 41aa8000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41ab0000 41ab3000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41abb000 41abc000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41ac5000 41c4d000 r-xp /usr/lib/libicui18n.so.57.1
41c5d000 41d63000 r-xp /usr/lib/libicuuc.so.57.1
41d79000 41d81000 r-xp /usr/lib/libdrm.so.2.4.0
41d89000 41d8b000 r-xp /usr/lib/libdri2.so.0.0.0
41d93000 41d99000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41da1000 41da6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41dae000 41dc7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43668000 43689000 r-xp /usr/lib/libexif.so.12.3.3
4369c000 4369e000 r-xp /usr/lib/libttrace.so.1.1
436a6000 436ab000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
436b3000 436b9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
436c2000 436ca000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
436d2000 436f4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
436fd000 43704000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4370d000 4370f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43717000 4371e000 r-xp /usr/lib/libminizip.so.1.0.0
43726000 43733000 r-xp /usr/lib/libail.so.0.1.0
4373c000 43742000 r-xp /usr/lib/libproc-stat.so.0.2.96
4374a000 4374b000 r-xp /usr/lib/libresponse.so.0.2.96
43753000 43758000 r-xp /usr/lib/libsystem.so.0.0.0
43762000 4382c000 r-xp /usr/lib/libCOREGL.so.4.0
43bd1000 43bdc000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43be5000 43bea000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43bf2000 43c09000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c16000 43c18000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c21000 4449f000 rw-p [stack:25713]
4449f000 444a0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
bed7a000 bed9b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25706)
Call Stack Count: 11
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: start_data_collection + 0x110 (0x413c0ae9) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2ae9
 2: create_base_gui + 0x152 (0x413bfe77) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e77
 3: app_create + 0x12 (0x413bfc6f) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1c6f
 4: (0x413919c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 5: appcore_efl_main + 0x246 (0x40044a5b) [/usr/lib/libappcore-efl.so.1] + 0x3a5b
 6: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: main + 0x116 (0x413bfbf7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1bf7
 8: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
 9: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
10: create_base_gui + 0xe7 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
info_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
07-10 18:20:25.623+0800 W/MM_CAMCORDER(25524): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
07-10 18:20:25.623+0800 W/MM_CAMCORDER(25524): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
07-10 18:20:25.628+0800 I/efl-extension(25524): efl_extension.c: eext_mod_init(40) > Init
07-10 18:20:25.643+0800 W/APPS    (  824): AppsViewNecklace.cpp: onTouchEventCancel(4949) >  touch cancel
07-10 18:20:26.498+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.533+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.533+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.533+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.553+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.583+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
07-10 18:20:26.583+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.593+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.593+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.613+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.643+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.643+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.643+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.653+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.668+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.668+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.668+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.683+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.693+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.693+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.698+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.713+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.723+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.723+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.728+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.738+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.753+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.753+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.753+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.768+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.783+0800 I/AUL     (25524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:26.783+0800 E/AUL     (25524): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:26.783+0800 E/AUL     (25524): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:26.813+0800 I/UXT     (25524): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:20:26.943+0800 E/MALI    (25524): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-10 18:20:26.948+0800 E/MALI    (25524): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-10 18:20:26.948+0800 E/MALI    (25524): [gpu-ddk] devel/graphics_drv/r4p0
07-10 18:20:26.948+0800 E/MALI    (25524): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-10 18:20:26.948+0800 E/MALI    (25524): [coregl] devel/graphics_engine/master
07-10 18:20:26.948+0800 E/MALI    (25524): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-10 18:20:26.948+0800 E/MALI    (25524): CHKѩ
07-10 18:20:27.643+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(273) > ------------------------------------------------
07-10 18:20:27.643+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
07-10 18:20:27.643+0800 E/rpm-installer(25514): rpm-appcore-intf.c: main(275) > ------------------------------------------------
07-10 18:20:27.658+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: sighandler(486) > child NORMAL exit [25514]
07-10 18:20:27.733+0800 E/RESOURCED(  635): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/25514/oom_score_adj failed
07-10 18:20:27.733+0800 E/RESOURCED(  635): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 25514
07-10 18:20:27.813+0800 I/MALI    (25524): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-10 18:20:27.818+0800 E/MALI    (25524): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
07-10 18:20:27.833+0800 I/AUL     (25535): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
07-10 18:20:27.848+0800 I/AUL     (25535): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
07-10 18:20:27.848+0800 E/AUL     (25535): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
07-10 18:20:27.853+0800 E/AUL     (25535): aul_path.c: __get_path(169) > root_path is NULL!
07-10 18:20:28.583+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-10 18:20:28.583+0800 E/PKGMGR_SERVER(25461): pkgmgr-server.c: main(2296) > package manager server terminated.
07-10 18:20:30.823+0800 W/AUL     (25601): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-10 18:20:30.828+0800 W/AUL_AMD (  518): amd_request.c: __request_handler(669) > __request_handler: 0
07-10 18:20:30.878+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-10 18:20:30.898+0800 I/AUL_AMD (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-10 18:20:30.898+0800 E/AUL_AMD (  518): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-10 18:20:30.898+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(1782) > caller pid : 25601
07-10 18:20:30.923+0800 E/RESOURCED(  635): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 3
07-10 18:20:30.923+0800 W/AUL_AMD (  518): amd_launch.c: _start_app(2218) > pad pid(-5)
07-10 18:20:30.923+0800 W/AUL_PAD ( 1342): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-10 18:20:30.923+0800 W/AUL_PAD ( 1342): launchpad.c: __send_result_to_caller(272) > Check app launching
07-10 18:20:30.928+0800 W/AUL_PAD (25525): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-10 18:20:30.928+0800 W/AUL_PAD (25525): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-10 18:20:30.928+0800 W/AUL_PAD (25525): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-10 18:20:30.928+0800 W/AUL_PAD (25525): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-10 18:20:30.993+0800 I/efl-extension(25525): efl_extension.c: eext_mod_init(40) > Init
07-10 18:20:30.998+0800 I/UXT     (25525): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-10 18:20:31.003+0800 W/AUL_PAD (25525): launchpad_loader.c: main(690) > [candidate] dlsym
07-10 18:20:31.003+0800 W/AUL_PAD (25525): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-10 18:20:31.003+0800 I/CAPI_APPFW_APPLICATION(25525): app_main.c: ui_app_main(704) > app_efl_main
07-10 18:20:31.008+0800 I/CAPI_APPFW_APPLICATION(25525): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-10 18:20:31.028+0800 W/AUL     (  518): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(25525) type(uiapp) bg(0)
07-10 18:20:31.028+0800 W/AUL     (25601): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25525)
07-10 18:20:31.028+0800 W/AUL_AMD (  518): amd_status.c: __socket_monitor_cb(1277) > (25525) was created
07-10 18:20:31.063+0800 W/STARTER (  759): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [25525]
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-10 18:20:31.223+0800 I/efl-extension(25525): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41879db0, elm_image, _activated_obj : 0x0, activated : 1
07-10 18:20:31.228+0800 E/EFL     (25525): elementary<25525> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-10 18:20:31.233+0800 E/EFL     (25525): elementary<25525> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4187a218) will be pushed
07-10 18:20:31.233+0800 I/efl-extension(25525): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x418909a0]'s widget[0x4187b6a8] to layout widget[0x4187a218]
07-10 18:20:31.238+0800 E/EFL     (25525): elementary<25525> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e9388 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-10 18:20:31.238+0800 E/EFL     (25525): elementary<25525> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e9388 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-10 18:20:31.243+0800 I/efl-extension(25525): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-10 18:20:31.588+0800 W/CRASH_MANAGER(25603): worker.c: worker_job(1205) > 112552573656e1499682031
07-10 18:20:32.038+0800 W/AUL_AMD (  518): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-10 18:20:32.038+0800 W/AUL_AMD (  518): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
07-10 18:20:32.228+0800 W/AUL_PAD ( 1342): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25525 pgid = 25525
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
07-10 18:21:24.653+0800 W/CRASH_MANAGER(25694): worker.c: worker_job(1205) > 112570673656e149968208
