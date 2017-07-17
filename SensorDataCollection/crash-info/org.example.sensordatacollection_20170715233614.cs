S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 3669
Date: 2017-07-15 23:36:14+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3669, uid 5000)

Register Information
r0   = 0x44816a70, r1   = 0x413c1bee
r2   = 0x00000025, r3   = 0x00000000
r4   = 0x401fc1e4, r5   = 0x44816a70
r6   = 0xbea57b08, r7   = 0x405ab000
r8   = 0x00000000, r9   = 0x40458824
r10  = 0x413c1bee, fp   = 0xbea57af4
ip   = 0x413c1bee, sp   = 0xbea57588
lr   = 0x404baf50, pc   = 0x404baf74
cpsr = 0x00000010

Memory Information
MemTotal:   490112 KB
MemFree:     20516 KB
Buffers:     28844 KB
Cached:     145068 KB
VmPeak:     109352 KB
VmSize:     107824 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24532 KB
VmRSS:       24528 KB
VmData:      44280 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3669 TID = 3669
3669 3978 3997 3998 3999 

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
41753000 4175a000 r-xp /usr/lib/libctx-shared.so.0.8.3
41762000 41767000 r-xp /usr/lib/libctx-client.so.0.8.3
4176f000 41781000 r-xp /usr/lib/libefl-assist.so.0.1.0
41789000 41841000 r-xp /usr/lib/libcairo.so.2.11200.14
4184c000 41856000 r-xp /usr/lib/libsensord-shared.so
4185e000 4186d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41876000 4188c000 r-xp /usr/lib/libtts.so
41895000 418b8000 r-xp /usr/lib/libui-extension.so.0.1.0
418c1000 418cc000 r-xp /usr/lib/libtbm.so.1.0.0
418d4000 418e2000 r-xp /usr/lib/libGLESv2.so.2.0
418eb000 418ec000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418f5000 418fb000 r-xp /usr/lib/libxcb-render.so.0.0.0
41903000 41906000 r-xp /usr/lib/libEGL.so.1.4
4190e000 41911000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41919000 4191a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41923000 41aab000 r-xp /usr/lib/libicui18n.so.57.1
41abb000 41ac3000 r-xp /usr/lib/libdrm.so.2.4.0
41acb000 41acd000 r-xp /usr/lib/libdri2.so.0.0.0
41ad5000 41adb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41ae3000 41ae8000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41af0000 41b09000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41b11000 41b32000 r-xp /usr/lib/libexif.so.12.3.3
41b45000 41b47000 r-xp /usr/lib/libttrace.so.1.1
41b4f000 41b54000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41b5c000 41b62000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41b6b000 41b73000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41b7b000 41b9d000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41ba6000 41bad000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41bb6000 41bb7000 r-xp /usr/lib/libresponse.so.0.2.96
41bbf000 41cf3000 rw-p [heap]
41cf3000 41df9000 r-xp /usr/lib/libicuuc.so.57.1
436a8000 436aa000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436b2000 436b9000 r-xp /usr/lib/libminizip.so.1.0.0
436c1000 436ce000 r-xp /usr/lib/libail.so.0.1.0
436d7000 436dd000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e5000 436ea000 r-xp /usr/lib/libsystem.so.0.0.0
436f4000 437be000 r-xp /usr/lib/libCOREGL.so.4.0
43c63000 43c6e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c77000 43c7c000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c84000 43c9b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43ca8000 43caa000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cb3000 444b2000 rw-p [stack:3978]
444b2000 444b3000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444cd000 444ce000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444ec000 444f4000 r-xp /usr/lib/libfeedback.so.0.1.4
444f6000 444f7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
449cd000 449cf000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
449d7000 449e2000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
449ea000 449f1000 r-xp /usr/lib/libmmfcommon.so.0.0.0
449f9000 44a11000 r-xp /usr/lib/libmmfsound.so.0.1.0
44a22000 44a26000 r-xp /usr/lib/libmmfsession.so.0.0.0
44a2f000 44a3a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44a47000 44a4b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44a53000 44a69000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44a71000 44ad2000 r-xp /usr/lib/libasound.so.2.0.0
44adc000 44adf000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44ae7000 44b1f000 r-xp /usr/lib/libpulse.so.0.16.2
44b20000 44b23000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44b2b000 44b73000 r-xp /usr/lib/libmdm.so.1.2.62
44b74000 44b77000 r-xp /usr/lib/libtinycompress.so.0.0.0
44b7f000 44b84000 r-xp /usr/lib/libjson.so.0.0.1
44b8c000 44bd5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44bde000 44c25000 r-xp /usr/lib/libsndfile.so.1.0.26
44c31000 44c40000 r-xp /usr/lib/libmdm-common.so.1.1.22
44c49000 44c6b000 r-xp /usr/lib/libvorbis.so.0.4.3
44c73000 44c77000 r-xp /usr/lib/libogg.so.0.7.1
44fff000 457fe000 rw-p [stack:3997]
457ff000 45ffe000 rw-p [stack:3998]
45fff000 46800000 rw-p [stack:3999]
bea38000 bea59000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3669)
Call Stack Count: 18
 0: _IO_vfprintf + 0xa4 (0x404baf74) [/lib/libc.so.6] + 0x3df74
 1: _IO_fprintf + 0x1c (0x404c4478) [/lib/libc.so.6] + 0x47478
 2: _data_collection + 0x2a (0x413c16cb) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x36cb
 3: _new_gyroscope_value + 0x86 (0x413c17f3) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x37f3
 4: (0x416de127) [/usr/lib/libcapi-system-sensor.so.0] + 0x9127
 5: (0x41734af0) [/usr/lib/libsensor.so.1] + 0x14af0
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
3:35:57.285+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.999348)
07-15 23:35:57.285+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:57.305+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.996933)
07-15 23:35:57.310+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(129)
07-15 23:35:57.310+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.996933)
07-15 23:35:57.310+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] animation stop!!
07-15 23:35:57.310+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-15 23:35:57.525+0800 I/efl-extension(  809): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-15 23:35:57.525+0800 I/efl-extension( 3669): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-15 23:35:57.525+0800 I/efl-extension( 3669): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x445074a8, elm_image, time_stamp : 9020518
07-15 23:35:57.530+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(130)
07-15 23:35:57.530+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-15 23:35:57.530+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] x(0), y(0)
07-15 23:35:57.530+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x437d4910 : elm_genlist] t_in(0.300000), pos_x(0)
07-15 23:35:57.530+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x437d4910 : elm_genlist] t_in(0.300000), pos_y(0)
07-15 23:35:57.570+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.247044)
07-15 23:35:57.570+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(130)
07-15 23:35:57.570+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.247044)
07-15 23:35:57.570+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(97)
07-15 23:35:57.595+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.405365)
07-15 23:35:57.595+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(97)
07-15 23:35:57.595+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.405365)
07-15 23:35:57.595+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(77)
07-15 23:35:57.630+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.576769)
07-15 23:35:57.630+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(77)
07-15 23:35:57.630+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.576769)
07-15 23:35:57.635+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(55)
07-15 23:35:57.665+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.721798)
07-15 23:35:57.665+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(55)
07-15 23:35:57.670+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.721798)
07-15 23:35:57.670+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(36)
07-15 23:35:57.705+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.836011)
07-15 23:35:57.705+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(36)
07-15 23:35:57.705+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.836011)
07-15 23:35:57.705+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(21)
07-15 23:35:57.740+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.913211)
07-15 23:35:57.740+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(21)
07-15 23:35:57.740+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.913211)
07-15 23:35:57.740+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(11)
07-15 23:35:57.760+0800 I/efl-extension(  809): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-15 23:35:57.780+0800 I/efl-extension( 3669): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-15 23:35:57.780+0800 I/efl-extension( 3669): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x445074a8, elm_image, time_stamp : 9020754
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.974981)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(11)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.974981)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(3)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(3)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1910 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] scrollto.x.animator(0x44730408)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1916 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] scrollto.y.animator(0x44730548)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] x(0), y(130)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x437d4910 : elm_genlist] t_in(0.300000), pos_x(0)
07-15 23:35:57.780+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x437d4910 : elm_genlist] t_in(0.300000), pos_y(130)
07-15 23:35:57.810+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.190568)
07-15 23:35:57.810+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(3)
07-15 23:35:57.810+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.190568)
07-15 23:35:57.810+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(27)
07-15 23:35:57.835+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.348530)
07-15 23:35:57.835+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(27)
07-15 23:35:57.835+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.348530)
07-15 23:35:57.840+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(47)
07-15 23:35:57.870+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.513822)
07-15 23:35:57.870+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(47)
07-15 23:35:57.870+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.513822)
07-15 23:35:57.870+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(68)
07-15 23:35:57.900+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.644934)
07-15 23:35:57.900+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(68)
07-15 23:35:57.900+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.644934)
07-15 23:35:57.900+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(84)
07-15 23:35:57.930+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.756063)
07-15 23:35:57.930+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(84)
07-15 23:35:57.930+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.756063)
07-15 23:35:57.930+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(99)
07-15 23:35:57.960+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.844948)
07-15 23:35:57.960+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(99)
07-15 23:35:57.960+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.844948)
07-15 23:35:57.960+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(110)
07-15 23:35:57.990+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.917146)
07-15 23:35:57.990+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(110)
07-15 23:35:57.990+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.917146)
07-15 23:35:57.995+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(119)
07-15 23:35:58.025+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.968642)
07-15 23:35:58.025+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(119)
07-15 23:35:58.025+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.968642)
07-15 23:35:58.030+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(126)
07-15 23:35:58.030+0800 I/efl-extension(  809): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-15 23:35:58.060+0800 I/efl-extension( 3669): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-15 23:35:58.060+0800 I/efl-extension( 3669): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x445074a8, elm_image, time_stamp : 9021025
07-15 23:35:58.060+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.996009)
07-15 23:35:58.060+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(126)
07-15 23:35:58.060+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.996009)
07-15 23:35:58.060+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.060+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(129)
07-15 23:35:58.060+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-15 23:35:58.060+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1910 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] scrollto.x.animator(0x44730688)
07-15 23:35:58.060+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1916 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] scrollto.y.animator(0x447307c8)
07-15 23:35:58.065+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x437d4910 : elm_genlist] x(0), y(130)
07-15 23:35:58.065+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x437d4910 : elm_genlist] t_in(0.300000), pos_x(0)
07-15 23:35:58.065+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x437d4910 : elm_genlist] t_in(0.300000), pos_y(130)
07-15 23:35:58.095+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.214577)
07-15 23:35:58.095+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.095+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.214577)
07-15 23:35:58.095+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.125+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.396775)
07-15 23:35:58.125+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.125+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.396775)
07-15 23:35:58.125+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.155+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.551184)
07-15 23:35:58.160+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.160+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.551184)
07-15 23:35:58.160+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.175+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.632672)
07-15 23:35:58.175+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.180+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.632672)
07-15 23:35:58.180+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.195+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.698767)
07-15 23:35:58.195+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.195+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.698767)
07-15 23:35:58.195+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.215+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.767447)
07-15 23:35:58.215+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.215+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.767447)
07-15 23:35:58.215+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.230+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.821623)
07-15 23:35:58.230+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.230+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.821623)
07-15 23:35:58.235+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.250+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.874472)
07-15 23:35:58.255+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.255+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.874472)
07-15 23:35:58.255+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.275+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.919716)
07-15 23:35:58.275+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.275+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.919716)
07-15 23:35:58.275+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.295+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.952661)
07-15 23:35:58.295+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.295+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.952661)
07-15 23:35:58.295+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.320+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.983705)
07-15 23:35:58.320+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.320+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.983705)
07-15 23:35:58.320+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.345+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.998591)
07-15 23:35:58.350+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.350+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.998591)
07-15 23:35:58.350+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:35:58.375+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] time(0.997128)
07-15 23:35:58.375+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(129)
07-15 23:35:58.375+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] time(0.997128)
07-15 23:35:58.380+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] animation stop!!
07-15 23:35:58.380+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x437d4910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-15 23:35:59.370+0800 E/EFL     ( 3669): ecore_x<3669> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=9022365 button=1
07-15 23:35:59.375+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d4910 : elm_genlist] mouse move
07-15 23:35:59.385+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d4910 : elm_genlist] mouse move
07-15 23:35:59.385+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d4910 : elm_genlist] hold(0), freeze(0)
07-15 23:35:59.395+0800 E/EFL     ( 3669): ecore_x<3669> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=9022390 button=1
07-15 23:35:59.450+0800 I/efl-extension( 3669): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 23:35:59.450+0800 I/efl-extension( 3669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4481a0a0, elm_image, _activated_obj : 0x445074a8, activated : 1
07-15 23:35:59.450+0800 I/efl-extension( 3669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 23:35:59.480+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44818340 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 23:35:59.480+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44818340 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 23:35:59.515+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 23:35:59.525+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44d16d38) will be pushed
07-15 23:35:59.530+0800 I/efl-extension( 3669): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44d39cd8]'s widget[0x44d34660] to layout widget[0x44d16d38]
07-15 23:35:59.535+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44818340 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 23:35:59.535+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44818340 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 23:35:59.535+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44818340 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 23:35:59.535+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44818340 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 23:35:59.535+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44818340 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 23:35:59.535+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44818340 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 23:35:59.540+0800 I/efl-extension( 3669): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 23:35:59.575+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:2796 _push_transition_cb() item(0x44d16d38) will transition
07-15 23:36:00.000+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:1193 _on_item_push_finished() item(0x44507910) transition finished
07-15 23:36:00.005+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:1218 _on_item_show_finished() item(0x44d16d38) transition finished
07-15 23:36:00.040+0800 W/WATCH_CORE(  930): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-15 23:36:00.040+0800 I/WATCH_CORE(  930): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-15 23:36:00.040+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 23:36:00.040+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 23:36:00.040+0800 I/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-15 23:36:00.045+0800 E/wnoti-service( 1048): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-15 23:36:00.045+0800 E/wnoti-service( 1048): wnoti-native-client.c: handle_cache_notification(737) > >>
07-15 23:36:00.045+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-15 23:36:00.045+0800 W/WECONN  (  500): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-15 23:36:00.045+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-15 23:36:00.045+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-15 23:36:00.045+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-15 23:36:00.045+0800 W/WECONN  (  500): <wc_manager_get_bearer_state:988> type : 1
07-15 23:36:00.065+0800 E/ALARM_MANAGER(  500): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(15-7-2017, 23:36:05), repeat(0), interval(0), type(-1073741822)
07-15 23:36:00.070+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [500].
07-15 23:36:00.095+0800 I/AUL     (  514): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-15 23:36:00.095+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 15
07-15 23:36:00.115+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-15 23:36:00.125+0800 W/SHealthService( 1167): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-15 23:36:00.140+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-15 23:36:00.140+0800 E/ALARM_MANAGER(  514): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1500132965, Sat Jul 15 23:36:05 2017
07-15 23:36:00.140+0800 E/ALARM_MANAGER(  514): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 2124192000, next duetime: 1500132965
07-15 23:36:00.140+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(2124192000)
07-15 23:36:00.140+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1500134348), due_time(1500132965)
07-15 23:36:00.155+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-15 23:36:00.155+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-15 23:36:00.155+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 15-7-2017, 15:36:05 (UTC).
07-15 23:36:00.155+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-15 23:36:00.155+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-15 23:36:00.165+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-15 23:36:00.170+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-15 23:36:00.185+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:385> }
07-15 23:36:00.185+0800 W/WECONN  (  500): <__wc_feature_wearonoff_monitor_cb:531> }
07-15 23:36:00.315+0800 E/EFL     ( 3669): ecore_x<3669> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=9023309 button=1
07-15 23:36:00.365+0800 E/EFL     ( 3669): ecore_x<3669> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=9023358 button=1
07-15 23:36:00.440+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 23:36:00.450+0800 E/SHealthService( 1167): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-15 23:36:00.460+0800 W/SHealthService( 1167): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-15 23:36:00.565+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:36:00.595+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:36:00.620+0800 W/SHealthCommon( 1167): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1500076800000.000000[0;m
07-15 23:36:00.660+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-15 23:36:00.665+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-15 23:36:00.680+0800 I/HealthDataService(  990): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 23:36:00.700+0800 I/healthData( 1167): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 23:36:00.760+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 23:36:00.775+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
07-15 23:36:00.775+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
07-15 23:36:00.775+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: preference_get_double(1214) > preference_get_double(1167) : pedometer_inactive_period error
07-15 23:36:00.780+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
07-15 23:36:00.780+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
07-15 23:36:00.780+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: preference_get_boolean(1173) > preference_get_boolean(1167) : inactive_test_mode_on error
07-15 23:36:00.780+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:36:00.795+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:36:01.375+0800 E/EFL     (  463): ecore_x<463> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3e00002 time=9023358
07-15 23:36:01.375+0800 E/EFL     ( 3669): ecore_x<3669> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=9023358
07-15 23:36:01.405+0800 E/EFL     (  463): ecore_x<463> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=9023358
07-15 23:36:04.435+0800 I/efl-extension( 3669): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 23:36:04.435+0800 I/efl-extension( 3669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44d15d10, elm_image, _activated_obj : 0x4481a0a0, activated : 1
07-15 23:36:04.435+0800 I/efl-extension( 3669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 23:36:04.480+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d35510 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 23:36:04.480+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d35510 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 23:36:04.485+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 23:36:04.520+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4473b910) will be pushed
07-15 23:36:04.520+0800 I/efl-extension( 3669): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44f114f8]'s widget[0x44f0d838] to layout widget[0x4473b910]
07-15 23:36:04.530+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d35510 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:36:04.530+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d35510 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:36:04.530+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d35510 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:36:04.530+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d35510 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:36:04.535+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d35510 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:36:04.535+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d35510 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:36:04.540+0800 I/efl-extension( 3669): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 23:36:04.585+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:2796 _push_transition_cb() item(0x4473b910) will transition
07-15 23:36:04.995+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-15 23:36:05.005+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:1193 _on_item_push_finished() item(0x44d16d38) transition finished
07-15 23:36:05.005+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-15 23:36:05.005+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:1218 _on_item_show_finished() item(0x4473b910) transition finished
07-15 23:36:05.020+0800 W/AUL     (  514): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(500) type(wakeup)
07-15 23:36:05.025+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_expired(1445) > alarm_id[2124192000] is expired.
07-15 23:36:05.025+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-15 23:36:05.025+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(2124192000)
07-15 23:36:05.025+0800 E/ALARM_MANAGER(  514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1591639436) is OVER.
07-15 23:36:05.025+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-15 23:36:05.025+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 15-7-2017, 15:59:08 (UTC).
07-15 23:36:05.025+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-15 23:36:05.025+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-15 23:36:05.025+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-15 23:36:05.025+0800 E/RESOURCED(  615): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 500
07-15 23:36:05.030+0800 E/ALARM_MANAGER(  500): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [2124192000]
07-15 23:36:05.030+0800 W/WECONN  (  500): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-15 23:36:05.030+0800 W/WECONN  (  500): <wc_manager_get_bearer_state:988> type : 1
07-15 23:36:05.030+0800 W/WECONN  (  500): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-15 23:36:05.035+0800 W/WECONN  (  500): <__connect_for_auto_switch:1706> { device=0x428fdc90, device->bt_address=1E:F0
07-15 23:36:05.040+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-15 23:36:05.125+0800 W/WECONN  (  500): <__connect_for_auto_switch:1719> }
07-15 23:36:05.130+0800 W/WECONN  (  500):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-15 23:36:05.130+0800 W/WECONN  (  500): <__wc_device_try_to_connect_on_wear:185> }
07-15 23:36:10.305+0800 W/WECONN  (  500): <__on_connect_socket:378> {
07-15 23:36:10.305+0800 W/WECONN  (  500): <__is_device_matched_to:2560> le : , br_edr : 1E:F0, identifier : 1E:F0
07-15 23:36:10.305+0800 W/WECONN  (  500): <__on_connect_socket:383> result(-29359863), state(0)
07-15 23:36:10.305+0800 W/WECONN  (  500): <__on_connect_socket:387> }
07-15 23:36:13.985+0800 E/RESOURCED(  615): block-monitor.c: block_logging(123) > pid 3669(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/admin/2017-07-15-23--36-acc.txt
07-15 23:36:14.010+0800 E/RESOURCED(  615): block-monitor.c: block_logging(123) > pid 3669(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/admin/2017-07-15-23--36-gyr.txt
07-15 23:36:14.100+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-15 23:36:14.105+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x4473b910) will be popped.
07-15 23:36:14.130+0800 I/efl-extension( 3669): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 23:36:14.130+0800 I/efl-extension( 3669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44f0de18, elm_image, _activated_obj : 0x44d15d10, activated : 1
07-15 23:36:14.130+0800 I/efl-extension( 3669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 23:36:14.150+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44f0e6e8 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 23:36:14.150+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44f0e6e8 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 23:36:14.155+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 23:36:14.170+0800 E/EFL     ( 3669): elementary<3669> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44f14b00) will be pushed
07-15 23:36:14.175+0800 I/efl-extension( 3669): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44dfdac8]'s widget[0x44dbb958] to layout widget[0x44f14b00]
07-15 23:36:14.185+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44f0e6e8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:36:14.185+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44f0e6e8 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:36:14.185+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44f0e6e8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:36:14.185+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44f0e6e8 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:36:14.190+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44f0e6e8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:36:14.190+0800 E/EFL     ( 3669): elementary<3669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44f0e6e8 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:36:14.195+0800 I/efl-extension( 3669): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 23:36:14.625+0800 W/CRASH_MANAGER( 4021): worker.c: worker_job(1205) > 110366973656e150013297
