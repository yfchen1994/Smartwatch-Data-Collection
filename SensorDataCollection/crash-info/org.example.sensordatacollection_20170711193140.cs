S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 1880
Date: 2017-07-11 19:31:40+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1880, uid 5000)

Register Information
r0   = 0xbeeec1ca, r1   = 0x00000000
r2   = 0x00000000, r3   = 0xbeeec1f9
r4   = 0x403119b8, r5   = 0x403119b8
r6   = 0x4031116c, r7   = 0xbeeec330
r8   = 0x403119b8, r9   = 0x41790548
r10  = 0x4031fb10, fp   = 0x00000000
ip   = 0xbeeec1fb, sp   = 0xbeeec070
lr   = 0x413c0ba9, pc   = 0x404f2b64
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      6756 KB
Buffers:     20100 KB
Cached:     171736 KB
VmPeak:      83968 KB
VmSize:      82440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23884 KB
VmRSS:       23884 KB
VmData:      18904 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 1880 TID = 1880
1880 1968 

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
416c8000 416cd000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
416d5000 416e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416ea000 4170b000 r-xp /usr/lib/libefl-extension.so.0.1.0
41713000 41718000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41720000 4174a000 r-xp /usr/lib/libsensor.so.1.9.5
41758000 4188c000 rw-p [heap]
4188c000 41893000 r-xp /usr/lib/libctx-shared.so.0.8.3
4189b000 418a0000 r-xp /usr/lib/libctx-client.so.0.8.3
418a8000 418ba000 r-xp /usr/lib/libefl-assist.so.0.1.0
418c2000 4197a000 r-xp /usr/lib/libcairo.so.2.11200.14
41985000 4198f000 r-xp /usr/lib/libsensord-shared.so
41997000 419a6000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
419af000 419c5000 r-xp /usr/lib/libtts.so
419ce000 419f1000 r-xp /usr/lib/libui-extension.so.0.1.0
419fa000 41a05000 r-xp /usr/lib/libtbm.so.1.0.0
41a0d000 41a1b000 r-xp /usr/lib/libGLESv2.so.2.0
41a24000 41a25000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a2e000 41a34000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a3c000 41a3f000 r-xp /usr/lib/libEGL.so.1.4
41a47000 41a4a000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a52000 41a53000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a5c000 41be4000 r-xp /usr/lib/libicui18n.so.57.1
41bf4000 41cfa000 r-xp /usr/lib/libicuuc.so.57.1
41d10000 41d18000 r-xp /usr/lib/libdrm.so.2.4.0
41d20000 41d22000 r-xp /usr/lib/libdri2.so.0.0.0
41d2a000 41d30000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d38000 41d3d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d45000 41d5e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
435ff000 43620000 r-xp /usr/lib/libexif.so.12.3.3
43633000 43635000 r-xp /usr/lib/libttrace.so.1.1
4363d000 43642000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4364a000 43650000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43659000 43661000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43669000 4368b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43694000 4369b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436a4000 436a6000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436ae000 436b5000 r-xp /usr/lib/libminizip.so.1.0.0
436bd000 436ca000 r-xp /usr/lib/libail.so.0.1.0
436d3000 436d9000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e1000 436e2000 r-xp /usr/lib/libresponse.so.0.2.96
436ea000 436ef000 r-xp /usr/lib/libsystem.so.0.0.0
436f9000 437c3000 r-xp /usr/lib/libCOREGL.so.4.0
43c68000 43c73000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c7c000 43c81000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c89000 43ca0000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43cad000 43caf000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cb8000 444b7000 rw-p [stack:1968]
444b7000 444b8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4485c000 4485d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4487b000 44883000 r-xp /usr/lib/libfeedback.so.0.1.4
44885000 44886000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
4488e000 44890000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44898000 448a3000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
448ab000 448b2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
448ba000 448d2000 r-xp /usr/lib/libmmfsound.so.0.1.0
448e3000 448e7000 r-xp /usr/lib/libmmfsession.so.0.0.0
448f0000 448fb000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44908000 4490c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44914000 4492a000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44932000 44993000 r-xp /usr/lib/libasound.so.2.0.0
4499d000 449a0000 r-xp /usr/lib/libpulse-simple.so.0.0.4
449a8000 449e0000 r-xp /usr/lib/libpulse.so.0.16.2
449e1000 449e4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
449ec000 44a34000 r-xp /usr/lib/libmdm.so.1.2.62
44a35000 44a38000 r-xp /usr/lib/libtinycompress.so.0.0.0
44a40000 44a45000 r-xp /usr/lib/libjson.so.0.0.1
44a4d000 44a96000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44a9f000 44ae6000 r-xp /usr/lib/libsndfile.so.1.0.26
44af2000 44b01000 r-xp /usr/lib/libmdm-common.so.1.1.22
44b0a000 44b2c000 r-xp /usr/lib/libvorbis.so.0.4.3
44b34000 44b38000 r-xp /usr/lib/libogg.so.0.7.1
beecc000 beeed000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1880)
Call Stack Count: 1
 0: strcat + 0x20 (0x404f2b64) [/lib/libc.so.6] + 0x75b64
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
hpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-11 19:31:31.380+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 0
07-11 19:31:31.380+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(1782) > caller pid : 807
07-11 19:31:31.380+0800 I/AUL_AMD (  522): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-11 19:31:31.395+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(2218) > pad pid(-5)
07-11 19:31:31.395+0800 W/AUL_PAD ( 1295): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-11 19:31:31.395+0800 W/AUL_PAD ( 1295): launchpad.c: __send_result_to_caller(272) > Check app launching
07-11 19:31:31.395+0800 W/AUL_PAD ( 1880): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-11 19:31:31.400+0800 W/AUL_PAD ( 1880): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-11 19:31:31.400+0800 W/AUL_PAD ( 1880): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-11 19:31:31.400+0800 W/AUL_PAD ( 1880): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-11 19:31:31.400+0800 E/RESOURCED(  630): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-11 19:31:31.455+0800 I/efl-extension( 1880): efl_extension.c: eext_mod_init(40) > Init
07-11 19:31:31.460+0800 I/UXT     ( 1880): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-11 19:31:31.475+0800 W/AUL_PAD ( 1880): launchpad_loader.c: main(690) > [candidate] dlsym
07-11 19:31:31.475+0800 W/AUL_PAD ( 1880): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-11 19:31:31.475+0800 I/CAPI_APPFW_APPLICATION( 1880): app_main.c: ui_app_main(704) > app_efl_main
07-11 19:31:31.480+0800 I/CAPI_APPFW_APPLICATION( 1880): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-11 19:31:31.495+0800 W/AUL     (  522): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(1880) type(uiapp) bg(0)
07-11 19:31:31.500+0800 W/AUL_AMD (  522): amd_status.c: __socket_monitor_cb(1277) > (1880) was created
07-11 19:31:31.500+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-11 19:31:31.500+0800 W/AUL     (  807): launch.c: app_request_to_launchpad(298) > request cmd(0) result(1880)
07-11 19:31:31.500+0800 W/W_HOME  (  807): util.c: apps_util_launch_main_operation(643) > Launch app:[sensordatacollection] ret:[0]
07-11 19:31:31.515+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [1880]
07-11 19:31:31.650+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 19:31:31.650+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-11 19:31:31.650+0800 I/efl-extension( 1880): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-11 19:31:31.650+0800 I/efl-extension( 1880): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-11 19:31:31.655+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437ea0a0, elm_image, _activated_obj : 0x0, activated : 1
07-11 19:31:31.655+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 19:31:31.660+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x437ea508) will be pushed
07-11 19:31:31.660+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x438b4188]'s widget[0x437eb998] to layout widget[0x437ea508]
07-11 19:31:31.660+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 19:31:31.660+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-11 19:31:31.660+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 19:31:31.675+0800 I/APP_CORE( 1880): appcore-efl.c: __do_app(453) > [APP 1880] Event: RESET State: CREATED
07-11 19:31:31.675+0800 I/CAPI_APPFW_APPLICATION( 1880): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-11 19:31:31.685+0800 I/APP_CORE( 1880): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-11 19:31:31.690+0800 I/APP_CORE( 1880): appcore-efl.c: __do_app(524) > [APP 1880] Initial Launching, call the resume_cb
07-11 19:31:31.690+0800 I/CAPI_APPFW_APPLICATION( 1880): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-11 19:31:31.695+0800 W/W_HOME  (  807): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-11 19:31:31.695+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 19:31:31.695+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 19:31:31.700+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 19:31:31.700+0800 W/W_HOME  (  807): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-11 19:31:31.700+0800 W/W_HOME  (  807): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-11 19:31:31.700+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 19:31:31.705+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 19:31:31.725+0800 W/APP_CORE( 1880): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200002
07-11 19:31:31.730+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 19:31:31.730+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-11 19:31:31.755+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-11 19:31:31.755+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-11 19:31:31.815+0800 W/W_HOME  (  807): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-11 19:31:31.815+0800 W/W_HOME  (  807): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-11 19:31:31.815+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 19:31:31.815+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 19:31:31.815+0800 W/W_HOME  (  807): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-11 19:31:31.820+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: PAUSE State: RUNNING
07-11 19:31:31.820+0800 I/CAPI_APPFW_APPLICATION(  807): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-11 19:31:31.820+0800 W/W_HOME  (  807): main.c: _appcore_pause_cb(487) > appcore pause
07-11 19:31:31.820+0800 W/W_HOME  (  807): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-11 19:31:31.820+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 19:31:31.820+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 19:31:31.820+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 19:31:31.820+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(807) status(bg) type(uiapp)
07-11 19:31:31.820+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[807] goes to (4)
07-11 19:31:31.820+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 807)'s state(4)
07-11 19:31:31.825+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[1880] goes to (3)
07-11 19:31:31.825+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(1880) status(fg) type(uiapp)
07-11 19:31:31.830+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 19:31:31.830+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 19:31:31.830+0800 W/W_HOME  (  807): rotary.c: rotary_deattach(156) > rotary_deattach:0x46142708
07-11 19:31:31.830+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-11 19:31:31.830+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46142708, elm_layout, func : 0x4005653d
07-11 19:31:31.830+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-11 19:31:31.830+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-11 19:31:31.830+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-11 19:31:31.830+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e3dd0, elm_box, _activated_obj : 0x46142708, activated : 1
07-11 19:31:31.830+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 19:31:31.830+0800 E/wnotib  (  807): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-11 19:31:31.830+0800 I/wnotib  (  807): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-11 19:31:31.860+0800 I/APP_CORE( 1880): appcore-efl.c: __do_app(453) > [APP 1880] Event: RESUME State: RUNNING
07-11 19:31:31.875+0800 W/APPS    (  807): AppsItem.cpp: aniFocusIndex(2351) >  [sensordatacollection:32] Focused[1], focusIdx[32]
07-11 19:31:31.875+0800 W/APPS    (  807): AppsItem.cpp: setLastIndex(1264) >  This is last index app [33:WDS_AT_OPT_GET_MORE_APPS_ABB], focusIdx[32]
07-11 19:31:31.875+0800 W/APPS    (  807): AppsViewNecklace.cpp: __onSignalHideNextPage(7029) >  Hide next page [0->0]
07-11 19:31:31.875+0800 W/W_HOME  (  807): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-11 19:31:31.875+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 19:31:31.875+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 19:31:31.875+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 19:31:31.875+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-11 19:31:31.875+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-11 19:31:31.875+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 19:31:31.875+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 19:31:31.875+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-11 19:31:31.885+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 19:31:31.885+0800 E/CAPI_APPFW_APP_CONTROL( 1014): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-11 19:31:31.885+0800 W/MUSIC_CONTROL_SERVICE( 1014): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1014]   [com.samsung.w-home]register msg port [false][0m
07-11 19:31:31.885+0800 I/wnotib  (  807): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-11 19:31:31.885+0800 E/wnotib  (  807): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-11 19:31:31.885+0800 W/wnotib  (  807): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-11 19:31:31.910+0800 W/APPS    (  807): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-11 19:31:32.225+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-11 19:31:32.385+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: MEM_FLUSH State: PAUSED
07-11 19:31:32.705+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=276672 button=1
07-11 19:31:32.705+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] mouse move
07-11 19:31:32.750+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=276712 button=1
07-11 19:31:32.785+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 19:31:32.800+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1880
07-11 19:31:32.800+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 19:31:32.835+0800 W/SHealthCommon( 1108): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499731200000.000000[0;m
07-11 19:31:32.940+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 19:31:32.945+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1880
07-11 19:31:32.950+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 19:31:32.955+0800 W/SHealthCommon( 1108): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-11 19:31:32.960+0800 I/HealthDataService(  998): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-11 19:31:32.975+0800 I/healthData( 1108): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-11 19:31:33.130+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 19:31:33.130+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44732998, elm_image, _activated_obj : 0x437ea0a0, activated : 1
07-11 19:31:33.130+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 19:31:33.135+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 19:31:33.155+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44732f78) will be pushed
07-11 19:31:33.155+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44730660]'s widget[0x44d05e30] to layout widget[0x44732f78]
07-11 19:31:33.160+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 19:31:33.165+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2796 _push_transition_cb() item(0x44732f78) will transition
07-11 19:31:33.245+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1193 _on_item_push_finished() item(0x437ea508) transition finished
07-11 19:31:33.245+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1218 _on_item_show_finished() item(0x44732f78) transition finished
07-11 19:31:33.255+0800 I/AUL_PAD ( 1956): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-11 19:31:34.469+0800 W/KEYROUTER(  461): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x5200002
07-11 19:31:34.474+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=278416
07-11 19:31:34.565+0800 W/KEYROUTER(  461): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x5200002
07-11 19:31:34.570+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=278533
07-11 19:31:34.570+0800 E/efl-extension( 1880): efl_extension_events.c: _eext_key_grab_rect_key_up_cb(240) > key up called
07-11 19:31:34.570+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-11 19:31:34.570+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x44732f78) will be popped.
07-11 19:31:34.570+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437ea0a0, elm_image, _activated_obj : 0x44732998, activated : 1
07-11 19:31:34.570+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 19:31:34.655+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2280 _pop_transition_cb() item(0x44732f78) will transition
07-11 19:31:35.095+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1218 _on_item_show_finished() item(0x437ea508) transition finished
07-11 19:31:35.095+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1274 _on_item_pop_finished() item(0x44732f78) transition finished
07-11 19:31:35.100+0800 I/efl-extension( 1880): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x44732998, obj: 0x44732998
07-11 19:31:35.100+0800 I/efl-extension( 1880): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-11 19:31:35.100+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-11 19:31:35.100+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x44730660 is freed
07-11 19:31:35.430+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=279388 button=1
07-11 19:31:35.435+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] mouse move
07-11 19:31:35.455+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] mouse move
07-11 19:31:35.455+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] hold(0), freeze(0)
07-11 19:31:35.465+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] mouse move
07-11 19:31:35.465+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] hold(0), freeze(0)
07-11 19:31:35.475+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=279448 button=1
07-11 19:31:35.480+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-11 19:31:35.480+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-11 19:31:35.480+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] x(0), y(130)
07-11 19:31:35.480+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x437d9910 : elm_genlist] t_in(0.300000), pos_x(0)
07-11 19:31:35.480+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x437d9910 : elm_genlist] t_in(0.300000), pos_y(130)
07-11 19:31:35.505+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.185439)
07-11 19:31:35.505+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-11 19:31:35.505+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.185439)
07-11 19:31:35.510+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(24)
07-11 19:31:35.550+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.424767)
07-11 19:31:35.550+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(24)
07-11 19:31:35.550+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.424767)
07-11 19:31:35.555+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(55)
07-11 19:31:35.595+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.625890)
07-11 19:31:35.595+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(55)
07-11 19:31:35.595+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.625890)
07-11 19:31:35.595+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(81)
07-11 19:31:35.635+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.767671)
07-11 19:31:35.635+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(81)
07-11 19:31:35.635+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.767671)
07-11 19:31:35.635+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(99)
07-11 19:31:35.670+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.868716)
07-11 19:31:35.670+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(99)
07-11 19:31:35.670+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.868716)
07-11 19:31:35.670+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(112)
07-11 19:31:35.695+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.929083)
07-11 19:31:35.700+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(112)
07-11 19:31:35.700+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.929083)
07-11 19:31:35.700+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(120)
07-11 19:31:35.725+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.971867)
07-11 19:31:35.730+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(120)
07-11 19:31:35.730+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.971867)
07-11 19:31:35.730+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(126)
07-11 19:31:35.760+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.996567)
07-11 19:31:35.760+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(126)
07-11 19:31:35.760+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.996567)
07-11 19:31:35.760+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-11 19:31:35.790+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.998168)
07-11 19:31:35.790+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(129)
07-11 19:31:35.790+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.998168)
07-11 19:31:35.790+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] animation stop!!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 E/EFL     ( 1880): evas_main<1880> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-11 19:31:35.795+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 19:31:35.795+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x447349e8, elm_image, _activated_obj : 0x437ea0a0, activated : 1
07-11 19:31:35.795+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 19:31:35.795+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 19:31:35.805+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44734fc8) will be pushed
07-11 19:31:35.805+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d8fae8]'s widget[0x44d07d08] to layout widget[0x44734fc8]
07-11 19:31:35.805+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 19:31:35.805+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-11 19:31:35.840+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2796 _push_transition_cb() item(0x44734fc8) will transition
07-11 19:31:36.260+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1193 _on_item_push_finished() item(0x437ea508) transition finished
07-11 19:31:36.265+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1218 _on_item_show_finished() item(0x44734fc8) transition finished
07-11 19:31:36.890+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: MEM_FLUSH State: PAUSED
07-11 19:31:37.350+0800 W/KEYROUTER(  461): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x5200002
07-11 19:31:37.355+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=281294
07-11 19:31:37.410+0800 W/KEYROUTER(  461): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x5200002
07-11 19:31:37.415+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=281377
07-11 19:31:37.415+0800 E/efl-extension( 1880): efl_extension_events.c: _eext_key_grab_rect_key_up_cb(240) > key up called
07-11 19:31:37.415+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-11 19:31:37.415+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x44734fc8) will be popped.
07-11 19:31:37.415+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437ea0a0, elm_image, _activated_obj : 0x447349e8, activated : 1
07-11 19:31:37.415+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 19:31:37.480+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2280 _pop_transition_cb() item(0x44734fc8) will transition
07-11 19:31:37.930+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1218 _on_item_show_finished() item(0x437ea508) transition finished
07-11 19:31:37.930+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1274 _on_item_pop_finished() item(0x44734fc8) transition finished
07-11 19:31:37.935+0800 I/efl-extension( 1880): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x447349e8, obj: 0x447349e8
07-11 19:31:37.935+0800 I/efl-extension( 1880): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-11 19:31:37.935+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-11 19:31:37.935+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x44d8fae8 is freed
07-11 19:31:38.230+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=282200 button=1
07-11 19:31:38.230+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] mouse move
07-11 19:31:38.260+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] mouse move
07-11 19:31:38.260+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] hold(0), freeze(0)
07-11 19:31:38.270+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] mouse move
07-11 19:31:38.270+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d9910 : elm_genlist] hold(0), freeze(0)
07-11 19:31:38.285+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=282253 button=1
07-11 19:31:38.285+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(130)
07-11 19:31:38.285+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-11 19:31:38.285+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x437d9910 : elm_genlist] x(0), y(260)
07-11 19:31:38.285+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x437d9910 : elm_genlist] t_in(0.300000), pos_x(0)
07-11 19:31:38.285+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x437d9910 : elm_genlist] t_in(0.300000), pos_y(260)
07-11 19:31:38.325+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.236130)
07-11 19:31:38.325+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(130)
07-11 19:31:38.325+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.236130)
07-11 19:31:38.325+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(160)
07-11 19:31:38.365+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.464142)
07-11 19:31:38.365+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(160)
07-11 19:31:38.365+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.464142)
07-11 19:31:38.365+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(190)
07-11 19:31:38.400+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.632802)
07-11 19:31:38.400+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(190)
07-11 19:31:38.400+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.632802)
07-11 19:31:38.405+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(212)
07-11 19:31:38.435+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.758568)
07-11 19:31:38.435+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(212)
07-11 19:31:38.435+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.758568)
07-11 19:31:38.435+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(228)
07-11 19:31:38.465+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.849277)
07-11 19:31:38.465+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(228)
07-11 19:31:38.465+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.849277)
07-11 19:31:38.470+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(240)
07-11 19:31:38.495+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.918143)
07-11 19:31:38.500+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(240)
07-11 19:31:38.500+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.918143)
07-11 19:31:38.500+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(249)
07-11 19:31:38.525+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.963396)
07-11 19:31:38.525+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(249)
07-11 19:31:38.525+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.963396)
07-11 19:31:38.530+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(255)
07-11 19:31:38.555+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.991319)
07-11 19:31:38.555+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(255)
07-11 19:31:38.555+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.991319)
07-11 19:31:38.555+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(258)
07-11 19:31:38.585+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] time(0.999995)
07-11 19:31:38.585+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(258)
07-11 19:31:38.585+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] time(0.999995)
07-11 19:31:38.585+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] animation stop!!
07-11 19:31:38.595+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 19:31:38.600+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x447349e8, elm_image, _activated_obj : 0x437ea0a0, activated : 1
07-11 19:31:38.600+0800 I/efl-extension( 1880): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 19:31:38.610+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44733268 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-11 19:31:38.610+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44733268 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-11 19:31:38.620+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 19:31:38.625+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4464ad68) will be pushed
07-11 19:31:38.625+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44db9f88]'s widget[0x44db1b58] to layout widget[0x4464ad68]
07-11 19:31:38.630+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44733268 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 19:31:38.630+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44733268 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 19:31:38.630+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44733268 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 19:31:38.630+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44733268 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 19:31:38.630+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44733268 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 19:31:38.630+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44733268 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 19:31:38.635+0800 I/efl-extension( 1880): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 19:31:38.635+0800 E/EFL     ( 1880): elementary<1880> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x437d9910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(260)
07-11 19:31:38.670+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:2796 _push_transition_cb() item(0x4464ad68) will transition
07-11 19:31:39.085+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1193 _on_item_push_finished() item(0x437ea508) transition finished
07-11 19:31:39.085+0800 E/EFL     ( 1880): elementary<1880> elc_naviframe.c:1218 _on_item_show_finished() item(0x4464ad68) transition finished
07-11 19:31:39.455+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=283422 button=1
07-11 19:31:39.510+0800 E/EFL     ( 1880): ecore_x<1880> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=283480 button=1
07-11 19:31:40.810+0800 W/CRASH_MANAGER( 1899): worker.c: worker_job(1205) > 110188073656e149977270
