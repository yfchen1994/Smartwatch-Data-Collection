S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 29346
Date: 2017-07-09 18:46:42+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000001
r2   = 0x00000000, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x417377fc
r6   = 0x00000001, r7   = 0xbea9bd30
r8   = 0x00000041, r9   = 0x40458824
r10  = 0x418256f8, fp   = 0x00000000
ip   = 0x404d9b50, sp   = 0xbea9bbe8
lr   = 0x413c0bdf, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:     49988 KB
Buffers:     16348 KB
Cached:     119204 KB
VmPeak:     110292 KB
VmSize:     109276 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19588 KB
VmRSS:       19588 KB
VmData:      48612 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23268 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 29346 TID = 29346
29346 29510 29511 29512 29513 

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
413be000 413c1000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
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
4176f000 41770000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41779000 4177b000 rw-p [heap]
4177b000 418af000 rw-p [heap]
418af000 41967000 r-xp /usr/lib/libcairo.so.2.11200.14
41972000 4197c000 r-xp /usr/lib/libsensord-shared.so
41984000 41993000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
4199c000 419b2000 r-xp /usr/lib/libtts.so
419bb000 419de000 r-xp /usr/lib/libui-extension.so.0.1.0
419e7000 419f2000 r-xp /usr/lib/libtbm.so.1.0.0
419fa000 41a08000 r-xp /usr/lib/libGLESv2.so.2.0
41a11000 41a17000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a1f000 41a22000 r-xp /usr/lib/libEGL.so.1.4
41a2a000 41a2f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a37000 41a3a000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a42000 41a43000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a4c000 41bd4000 r-xp /usr/lib/libicui18n.so.57.1
41be4000 41cea000 r-xp /usr/lib/libicuuc.so.57.1
41d00000 41d08000 r-xp /usr/lib/libdrm.so.2.4.0
41d10000 41d12000 r-xp /usr/lib/libdri2.so.0.0.0
41d1a000 41d20000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d28000 41d2d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d35000 41d4e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
435ef000 43610000 r-xp /usr/lib/libexif.so.12.3.3
43623000 43625000 r-xp /usr/lib/libttrace.so.1.1
4362d000 43632000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4363a000 43640000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43649000 43651000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43659000 4367b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43684000 4368b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43694000 43696000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4369e000 436a5000 r-xp /usr/lib/libminizip.so.1.0.0
436ad000 436ba000 r-xp /usr/lib/libail.so.0.1.0
436c3000 436c9000 r-xp /usr/lib/libproc-stat.so.0.2.96
436d1000 436d2000 r-xp /usr/lib/libresponse.so.0.2.96
436da000 436df000 r-xp /usr/lib/libsystem.so.0.0.0
436e9000 437b3000 r-xp /usr/lib/libCOREGL.so.4.0
43b58000 43b63000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43b6c000 43b71000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b79000 43b90000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c9d000 43c9f000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
444a7000 444a8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44729000 44f28000 rw-p [stack:29510]
44f29000 45728000 rw-p [stack:29511]
45729000 45f28000 rw-p [stack:29512]
45f29000 46828000 rw-p [stack:29513]
bea7c000 bea9d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29346)
Call Stack Count: 17
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: _data_collection + 0x66 (0x413c0bdf) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2bdf
 2: _new_gyroscope_value + 0x8a (0x413c0b63) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2b63
 3: (0x416d1127) [/usr/lib/libcapi-system-sensor.so.0] + 0x9127
 4: (0x4171aaf0) [/usr/lib/libsensor.so.1] + 0x14af0
 5: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 6: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 7: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 8: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
 9: (0x402fe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
10: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
12: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x116 (0x413bfb87) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1b87
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
age[0], focusIndex[0], ItemListSize[34], FocusPrev[0], FocusNext[0], FocusRecent[1], HideNextPage[0]
07-09 18:46:22.060+0800 W/APPS    (  982): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[0], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-09 18:46:22.065+0800 W/APPS    (  982): AppsItem.cpp: aniFocusIndex(2351) >  [电话:0] Focused[0], focusIdx[0]
07-09 18:46:22.065+0800 W/APPS    (  982): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[0]
07-09 18:46:22.065+0800 W/APPS    (  982): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-09 18:46:22.065+0800 W/APPS    (  982): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-09 18:46:22.070+0800 I/efl-extension( 1169): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-09 18:46:22.070+0800 I/efl-extension( 2946): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-09 18:46:22.070+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 22
07-09 18:46:22.070+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(999) > app status : 4
07-09 18:46:22.070+0800 E/APP_CORE( 2946): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
07-09 18:46:22.075+0800 I/APP_CORE( 2946): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
07-09 18:46:22.075+0800 I/CAPI_APPFW_APPLICATION( 2946): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
07-09 18:46:22.075+0800 I/WIFI_EFL( 2946): app_main.c: app_terminate(5088) > [Enter]
07-09 18:46:22.075+0800 I/WIFI_EFL( 2946): app_main.c: _app_release(4823) > [Enter]
07-09 18:46:22.075+0800 E/WIFI_EFL( 2946): idler.c: idler_util_managed_idle_cleanup(69) > Managed idler list is empty.
07-09 18:46:22.075+0800 E/WIFI_EFL( 2946): wifi_manager.c: wifi_manager_ap_destroy(850) > AP object is NULL.
07-09 18:46:22.075+0800 W/CAPI_NETWORK_WECONN( 2946): <weconn_destroy:616> } ...weconn handle destoried
07-09 18:46:22.110+0800 I/CAPI_NETWORK_WIFI( 2946): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
07-09 18:46:22.110+0800 I/efl-extension( 2946): efl_extension_circle_surface.c: eext_circle_surface_del(1359) > Surface[0x454c3e58] is going to free in eext_circle_surface_del API.
07-09 18:46:22.110+0800 I/efl-extension( 2946): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(962) > Private Surface will be initialized for widget[0x4579b548], circle_obj[0x457a7e40]!
07-09 18:46:22.110+0800 I/efl-extension( 2946): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(649) > surface 0x47903f68 = w: 0 h: 0  obj 0x4579b548 w: 360 h: 360
07-09 18:46:22.110+0800 I/efl-extension( 2946): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(673) > Surface will be initialized! surface->w= 360 surface->h = 360
07-09 18:46:22.110+0800 I/efl-extension( 2946): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x4578ad28 is freed
07-09 18:46:22.110+0800 I/efl-extension( 2946): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x454c3e58 is freed
07-09 18:46:22.115+0800 I/WIFI_EFL( 2946): app_main.c: __main_del_cb(4149) > [Enter]
07-09 18:46:22.115+0800 I/CAPI_APPFW_APPLICATION( 2946): app_main.c: app_efl_exit(145) > app_efl_exit
07-09 18:46:22.115+0800 I/efl-extension( 2946): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x456c9b40, obj: 0x456c9b40
07-09 18:46:22.115+0800 I/efl-extension( 2946): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
07-09 18:46:22.115+0800 I/efl-extension( 2946): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
07-09 18:46:22.115+0800 I/efl-extension( 2946): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
07-09 18:46:22.115+0800 I/efl-extension( 2946): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-09 18:46:22.115+0800 I/efl-extension( 1169): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-09 18:46:22.115+0800 E/EFL     ( 2946): elementary<2946> elm_genlist.c:6964 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-09 18:46:22.120+0800 E/EFL     ( 2946): elementary<2946> elm_genlist.c:6964 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
07-09 18:46:22.120+0800 E/EFL     ( 2946): elementary<2946> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x456c9b40 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 18:46:22.120+0800 E/EFL     ( 2946): elementary<2946> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x456c9b40 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-09 18:46:22.120+0800 E/EFL     ( 2946): elementary<2946> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x456c9b40 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 18:46:22.120+0800 E/EFL     ( 2946): elementary<2946> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x456c9b40 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-09 18:46:22.120+0800 I/efl-extension( 2946): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-09 18:46:22.120+0800 I/efl-extension( 2946): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x47903f68 is freed
07-09 18:46:22.120+0800 I/efl-extension( 2946): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x4579b548
07-09 18:46:22.120+0800 I/efl-extension( 2946): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-09 18:46:22.120+0800 I/efl-extension( 2946): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x456c9b40, elm_genlist, func : 0x400efe89
07-09 18:46:22.120+0800 I/efl-extension( 2946): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-09 18:46:22.150+0800 I/efl-extension(  982): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-09 18:46:22.150+0800 I/efl-extension(  982): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x473695d8, elm_layout, time_stamp : 34139709
07-09 18:46:22.150+0800 W/APPS    (  982): AppsViewNecklace.cpp: runRotaryForwardAnimation(3576) >  EditMode[0], focusPage[0], focusIndex[0], ItemListSize[34], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
07-09 18:46:22.150+0800 W/APPS    (  982): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[1], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[34]
07-09 18:46:22.155+0800 W/APPS    (  982): AppsItem.cpp: aniFocusIndex(2351) >  [三星健康:1] Focused[0], focusIdx[1]
07-09 18:46:22.155+0800 W/APPS    (  982): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[1]
07-09 18:46:22.155+0800 W/APPS    (  982): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-09 18:46:22.155+0800 W/APPS    (  982): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-09 18:46:22.155+0800 W/APPS    (  982): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-09 18:46:22.175+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:46:22.175+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:46:22.175+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:46:22.175+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-09 18:46:22.175+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-09 18:46:22.175+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:46:22.175+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-09 18:46:22.175+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-09 18:46:22.185+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:46:22.185+0800 E/CAPI_APPFW_APP_CONTROL( 1326): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-09 18:46:22.185+0800 W/MUSIC_CONTROL_SERVICE( 1326): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1326]   [com.samsung.w-home]register msg port [true][0m
07-09 18:46:22.185+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 14
07-09 18:46:22.190+0800 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 982
07-09 18:46:22.195+0800 I/APP_CORE( 2946): appcore-efl.c: __after_loop(1243) > [APP 2946] After terminate() callback
07-09 18:46:22.195+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 6
07-09 18:46:22.195+0800 W/AUL     (  527): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(1170) type(wakeup)
07-09 18:46:22.195+0800 W/AUL_AMD (  527): amd_request.c: __foward_cmd(161) > __forward_cmd: 2946 2946
07-09 18:46:22.195+0800 E/AUL     (  527): app_sock.c: __connect_client_sock(196) > connect error: 111
07-09 18:46:22.195+0800 E/AUL     (  527): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
07-09 18:46:22.215+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-09 18:46:22.240+0800 I/MALI    ( 2946): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
07-09 18:46:22.240+0800 I/MALI    ( 2946): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=2946   close drm_fd=29 
07-09 18:46:22.240+0800 I/MALI    ( 2946): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
07-09 18:46:22.280+0800 W/MUSIC_CONTROL_SERVICE( 1326): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1326]   [MUSIC_PLAYER_EVENT][0m
07-09 18:46:22.295+0800 E/AUL     (  527): app_sock.c: __connect_client_sock(196) > connect error: 111
07-09 18:46:22.295+0800 E/AUL     (  527): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
07-09 18:46:22.310+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:46:22.310+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:46:22.310+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:46:22.310+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-09 18:46:22.310+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-09 18:46:22.310+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:46:22.310+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-09 18:46:22.310+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:46:22.315+0800 I/UXT     ( 1170): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
07-09 18:46:22.315+0800 I/UXT     ( 1170): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-09 18:46:22.315+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:46:22.320+0800 W/W_HOME  (  982): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-09 18:46:22.320+0800 E/W_HOME  (  982): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-09 18:46:22.325+0800 W/MUSIC_CONTROL_SERVICE( 1326): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1326]   [MUSIC_PLAYER_EVENT][0m
07-09 18:46:22.335+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:46:22.335+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:46:22.335+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:46:22.340+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-09 18:46:22.340+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-09 18:46:22.340+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:46:22.340+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
07-09 18:46:22.340+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:46:22.350+0800 I/UXT     (12953): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
07-09 18:46:22.350+0800 I/UXT     (12953): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
07-09 18:46:22.350+0800 I/UXT     (12953): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-09 18:46:22.350+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:46:22.355+0800 W/W_HOME  (  982): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
07-09 18:46:22.355+0800 E/W_HOME  (  982): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
07-09 18:46:22.405+0800 W/APPS    (  982): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-09 18:46:22.595+0800 E/AUL     (  527): app_sock.c: __connect_client_sock(196) > connect error: 111
07-09 18:46:22.595+0800 E/AUL     (  527): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
07-09 18:46:22.600+0800 I/AUL_AMD (  527): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29171
07-09 18:46:22.600+0800 W/AUL     (  527): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29171)
07-09 18:46:22.695+0800 W/AUL_AMD (  527): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
07-09 18:46:22.705+0800 W/AUL_AMD (  527): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
07-09 18:46:22.705+0800 W/AUL_AMD (  527): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
07-09 18:46:22.730+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1170 pgid = 1170
07-09 18:46:22.730+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:46:22.870+0800 E/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
07-09 18:46:22.870+0800 E/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(12953) are closed. delete client info
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
07-09 18:46:22.870+0800 E/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  12953
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: UnregisterMessagePortByDiscon(273) > _MessagePortService::UnregisterMessagePortByDiscon
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.870+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: unregistermessageport(257) > unregistermessageport
07-09 18:46:22.960+0800 I/AUL_AMD (  527): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1170
07-09 18:46:22.960+0800 W/AUL     (  527): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(1170)
07-09 18:46:23.060+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-09 18:46:23.060+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 12953 pgid = -1
07-09 18:46:23.060+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
07-09 18:46:23.060+0800 W/AUL_PAD ( 1157): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-09 18:46:23.065+0800 I/AUL_AMD (  527): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12953
07-09 18:46:23.065+0800 W/AUL     (  527): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12953)
07-09 18:46:23.385+0800 I/UXT     ( 2946): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
07-09 18:46:23.385+0800 I/UXT     ( 2946): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
07-09 18:46:23.385+0800 I/UXT     ( 2946): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
07-09 18:46:23.690+0800 I/efl-extension( 2946): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-09 18:46:24.075+0800 W/AUL_AMD (  527): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
07-09 18:46:24.090+0800 W/AUL     (29392): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.wifi]
07-09 18:46:24.095+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 23
07-09 18:46:24.095+0800 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
07-09 18:46:24.095+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 2946
07-09 18:46:24.095+0800 W/AUL_AMD (  527): amd_request.c: __send_app_termination_signal(528) > send dead signal done
07-09 18:46:24.105+0800 I/AUL_AMD (  527): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2946
07-09 18:46:24.105+0800 W/AUL     (  527): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(2946)
07-09 18:46:28.820+0800 W/WATCH_CORE( 1194): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-09 18:46:28.820+0800 I/WATCH_CORE( 1194): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-09 18:46:28.825+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:46:28.825+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:46:28.825+0800 I/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-09 18:46:28.850+0800 E/wnoti-service(  910): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 1 to 2 
07-09 18:46:28.890+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 1 -> 2
07-09 18:46:28.900+0800 W/WECONN  (  505): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
07-09 18:46:28.900+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_OFF
07-09 18:46:28.900+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:385> }
07-09 18:46:28.900+0800 W/WECONN  (  505): <__wc_feature_wearonoff_monitor_cb:531> }
07-09 18:46:28.950+0800 W/SHealthService( 1309): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
07-09 18:46:37.785+0800 E/PKGMGR_SERVER(29439): pkgmgr-server.c: main(2242) > package manager server start
07-09 18:46:37.895+0800 E/PKGMGR_SERVER(29439): pkgmgr-server.c: req_cb(1135) > KILL_APP start 
07-09 18:46:37.905+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 14
07-09 18:46:37.915+0800 W/AUL_AMD (  527): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
07-09 18:46:37.915+0800 E/PKGMGR_SERVER(29439): pkgmgr-server.c: req_cb(1154) > CHECK_KILL_APP done[return = 0] 
07-09 18:46:40.405+0800 E/PKGMGR_SERVER(29439): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
07-09 18:46:40.405+0800 E/PKGMGR_SERVER(29439): pkgmgr-server.c: main(2296) > package manager server terminated.
07-09 18:46:41.785+0800 W/AUL     (29502): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-09 18:46:41.790+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 0
07-09 18:46:41.820+0800 I/AUL_AMD (  527): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
07-09 18:46:41.845+0800 I/AUL_AMD (  527): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
07-09 18:46:41.845+0800 E/AUL_AMD (  527): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
07-09 18:46:41.845+0800 W/AUL_AMD (  527): amd_launch.c: _start_app(1782) > caller pid : 29502
07-09 18:46:41.870+0800 E/RESOURCED(  627): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 8
07-09 18:46:41.870+0800 W/AUL_AMD (  527): amd_launch.c: _start_app(2218) > pad pid(-5)
07-09 18:46:41.875+0800 W/AUL_PAD ( 1157): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-09 18:46:41.875+0800 W/AUL_PAD ( 1157): launchpad.c: __send_result_to_caller(272) > Check app launching
07-09 18:46:41.875+0800 W/AUL_PAD (29346): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-09 18:46:41.875+0800 W/AUL_PAD (29346): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-09 18:46:41.875+0800 W/AUL_PAD (29346): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-09 18:46:41.880+0800 W/AUL_PAD (29346): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-09 18:46:41.970+0800 I/efl-extension(29346): efl_extension.c: eext_mod_init(40) > Init
07-09 18:46:41.980+0800 I/UXT     (29346): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-09 18:46:41.980+0800 W/AUL_PAD (29346): launchpad_loader.c: main(690) > [candidate] dlsym
07-09 18:46:41.980+0800 W/AUL_PAD (29346): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-09 18:46:41.985+0800 I/CAPI_APPFW_APPLICATION(29346): app_main.c: ui_app_main(704) > app_efl_main
07-09 18:46:41.990+0800 I/CAPI_APPFW_APPLICATION(29346): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-09 18:46:42.075+0800 W/AUL     (  527): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(29346) type(uiapp) bg(0)
07-09 18:46:42.075+0800 W/AUL_AMD (  527): amd_status.c: __socket_monitor_cb(1277) > (29346) was created
07-09 18:46:42.075+0800 W/STARTER (  866): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [29346]
07-09 18:46:42.075+0800 W/AUL     (29502): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29346)
07-09 18:46:42.200+0800 I/efl-extension(29346): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-09 18:46:42.200+0800 I/efl-extension(29346): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-09 18:46:42.200+0800 I/efl-extension(29346): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-09 18:46:42.200+0800 I/efl-extension(29346): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-09 18:46:42.200+0800 I/efl-extension(29346): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44507598, elm_image, _activated_obj : 0x0, activated : 1
07-09 18:46:42.205+0800 E/EFL     (29346): elementary<29346> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-09 18:46:42.210+0800 E/EFL     (29346): elementary<29346> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44507a00) will be pushed
07-09 18:46:42.210+0800 I/efl-extension(29346): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x43bae2f0]'s widget[0x44508e90] to layout widget[0x44507a00]
07-09 18:46:42.210+0800 E/EFL     (29346): elementary<29346> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x43ba1910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 18:46:42.210+0800 E/EFL     (29346): elementary<29346> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x43ba1910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-09 18:46:42.210+0800 I/efl-extension(29346): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-09 18:46:42.270+0800 I/APP_CORE(29346): appcore-efl.c: __do_app(453) > [APP 29346] Event: RESET State: CREATED
07-09 18:46:42.270+0800 I/CAPI_APPFW_APPLICATION(29346): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-09 18:46:42.305+0800 I/APP_CORE(29346): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-09 18:46:42.305+0800 I/APP_CORE(29346): appcore-efl.c: __do_app(524) > [APP 29346] Initial Launching, call the resume_cb
07-09 18:46:42.305+0800 I/CAPI_APPFW_APPLICATION(29346): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-09 18:46:42.325+0800 W/W_HOME  (  982): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-09 18:46:42.325+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 18:46:42.325+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 18:46:42.325+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 18:46:42.325+0800 W/W_HOME  (  982): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-09 18:46:42.325+0800 W/W_HOME  (  982): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-09 18:46:42.330+0800 W/W_INDICATOR(  867): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-09 18:46:42.330+0800 W/W_INDICATOR(  867): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-09 18:46:42.360+0800 W/APP_CORE(29346): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
07-09 18:46:42.365+0800 E/EFL     (29346): elementary<29346> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x43ba1910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-09 18:46:42.365+0800 E/EFL     (29346): elementary<29346> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x43ba1910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-09 18:46:42.400+0800 E/EFL     (29346): elementary<29346> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x43ba1910 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-09 18:46:42.400+0800 E/EFL     (29346): elementary<29346> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x43ba1910 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-09 18:46:42.405+0800 W/WATCH_CORE( 1194): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-09 18:46:42.405+0800 I/WATCH_CORE( 1194): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-09 18:46:42.405+0800 I/CAPI_WATCH_APPLICATION( 1194): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-09 18:46:42.405+0800 E/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(616) > 
07-09 18:46:42.405+0800 I/watchface-loader( 1194): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-09 18:46:42.410+0800 E/wnoti-service(  910): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-09 18:46:42.410+0800 E/wnoti-service(  910): wnoti-native-client.c: handle_cache_notification(737) > >>
07-09 18:46:42.410+0800 E/WMS     (  522): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-09 18:46:42.410+0800 W/WECONN  (  505): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-09 18:46:42.410+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-09 18:46:42.410+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-09 18:46:42.410+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-09 18:46:42.415+0800 W/WECONN  (  505): <wc_manager_get_bearer_state:988> type : 1
07-09 18:46:42.425+0800 E/ALARM_MANAGER(  505): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(9-7-2017, 18:46:47), repeat(0), interval(0), type(-1073741822)
07-09 18:46:42.430+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [505].
07-09 18:46:42.480+0800 I/MALI    (  982): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf218] swap changed from sync to async
07-09 18:46:42.495+0800 W/AUL     (  527): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(982) status(bg) type(uiapp)
07-09 18:46:42.495+0800 W/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[982] goes to (4)
07-09 18:46:42.495+0800 E/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 982)'s state(4)
07-09 18:46:42.495+0800 W/STARTER (  866): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[29346] goes to (3)
07-09 18:46:42.495+0800 W/AUL_AMD (  527): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-09 18:46:42.495+0800 W/AUL_AMD (  527): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-09 18:46:42.495+0800 W/AUL     (  527): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(29346) status(fg) type(uiapp)
07-09 18:46:42.515+0800 I/AUL     (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-09 18:46:42.520+0800 W/AUL_AMD (  527): amd_request.c: __request_handler(669) > __request_handler: 15
07-09 18:46:42.520+0800 W/W_HOME  (  982): event_manager.c: _window_visibility_cb(466) > Window [0x3600003] is now visible(1)
07-09 18:46:42.520+0800 W/W_HOME  (  982): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-09 18:46:42.520+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 18:46:42.520+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 18:46:42.525+0800 W/W_HOME  (  982): main.c: _window_visibility_cb(963) > Window [0x3600003] is now visible(1)
07-09 18:46:42.525+0800 I/APP_CORE(  982): appcore-efl.c: __do_app(453) > [APP 982] Event: PAUSE State: RUNNING
07-09 18:46:42.525+0800 I/CAPI_APPFW_APPLICATION(  982): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-09 18:46:42.525+0800 W/W_HOME  (  982): main.c: _appcore_pause_cb(487) > appcore pause
07-09 18:46:42.525+0800 W/W_HOME  (  982): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-09 18:46:42.525+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 18:46:42.525+0800 I/AUL_AMD (  527): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-09 18:46:42.535+0800 I/AUL_AMD (  527): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-09 18:46:42.535+0800 E/ALARM_MANAGER(  520): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499597207, Sun Jul  9 18:46:47 2017
07-09 18:46:42.535+0800 E/ALARM_MANAGER(  520): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 410538602, next duetime: 1499597207
07-09 18:46:42.535+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(410538602)
07-09 18:46:42.535+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499605148), due_time(1499597207)
07-09 18:46:42.540+0800 E/TBM     (  402): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:402] error(Device or resource busy) _tgl_destroy:141 key:29
07-09 18:46:42.545+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-09 18:46:42.550+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 18:46:42.550+0800 W/W_HOME  (  982): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-09 18:46:42.550+0800 W/W_HOME  (  982): rotary.c: rotary_deattach(156) > rotary_deattach:0x473695d8
07-09 18:46:42.550+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-09 18:46:42.550+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x473695d8, elm_layout, func : 0x4005653d
07-09 18:46:42.550+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-09 18:46:42.550+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-09 18:46:42.550+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-09 18:46:42.550+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e3bb8, elm_box, _activated_obj : 0x473695d8, activated : 1
07-09 18:46:42.550+0800 I/efl-extension(  982): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-09 18:46:42.550+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 18:46:42.550+0800 I/wnotib  (  982): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6221) > Return true for 60, -1017.
07-09 18:46:42.550+0800 I/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-09 18:46:42.560+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-09 18:46:42.560+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 9-7-2017, 10:46:47 (UTC).
07-09 18:46:42.560+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-09 18:46:42.560+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-09 18:46:42.565+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-09 18:46:42.570+0800 E/ALARM_MANAGER(  520): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-09 18:46:42.580+0800 I/APP_CORE(29346): appcore-efl.c: __do_app(453) > [APP 29346] Event: RESUME State: RUNNING
07-09 18:46:42.580+0800 W/WECONN  (  505): <__wc_device_on_wear_onoff_changed_cb:385> }
07-09 18:46:42.580+0800 W/WECONN  (  505): <__wc_feature_wearonoff_monitor_cb:531> }
07-09 18:46:42.585+0800 W/W_HOME  (  982): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-09 18:46:42.585+0800 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-09 18:46:42.585+0800 I/wnotib  (  982): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-09 18:46:42.585+0800 E/wnotib  (  982): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-09 18:46:42.585+0800 W/wnotib  (  982): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [5], notiboard card appending count [6].
07-09 18:46:42.590+0800 E/CAPI_APPFW_APP_CONTROL( 1326): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-09 18:46:42.590+0800 W/MUSIC_CONTROL_SERVICE( 1326): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1326]   [com.samsung.w-home]register msg port [false][0m
07-09 18:46:42.605+0800 W/APPS    (  982): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-09 18:46:42.615+0800 W/W_INDICATOR(  867): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-09 18:46:42.615+0800 W/W_INDICATOR(  867): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-09 18:46:42.625+0800 W/SHealthService( 1309): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-09 18:46:42.900+0800 W/CRASH_MANAGER(29518): worker.c: worker_job(1205) > 112934673656e149959720
