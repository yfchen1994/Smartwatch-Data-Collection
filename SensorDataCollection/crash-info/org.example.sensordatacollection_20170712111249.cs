S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 4807
Date: 2017-07-12 11:12:49+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4807, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x448007b8, r3   = 0x00000000
r4   = 0x4138db70, r5   = 0x448007b8
r6   = 0xbef66d10, r7   = 0x405ab000
r8   = 0x00000000, r9   = 0x40458824
r10  = 0x413c1714, fp   = 0xbef66cfc
ip   = 0x00000000, sp   = 0xbef66790
lr   = 0x404bb0ec, pc   = 0x404bb054
cpsr = 0x40000010

Memory Information
MemTotal:   491132 KB
MemFree:     15064 KB
Buffers:     25132 KB
Cached:     164084 KB
VmPeak:     108828 KB
VmSize:     106792 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24240 KB
VmRSS:       24236 KB
VmData:      43256 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 4807 TID = 4807
4807 5001 5032 5033 

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
41895000 418a0000 r-xp /usr/lib/libtbm.so.1.0.0
418a8000 418a9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418b7000 419ec000 rw-p [heap]
419ec000 41a0f000 r-xp /usr/lib/libui-extension.so.0.1.0
41a18000 41a26000 r-xp /usr/lib/libGLESv2.so.2.0
41a2f000 41a35000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a3d000 41a40000 r-xp /usr/lib/libEGL.so.1.4
41a48000 41a4b000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a53000 41a54000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a5d000 41be5000 r-xp /usr/lib/libicui18n.so.57.1
41bf5000 41cfb000 r-xp /usr/lib/libicuuc.so.57.1
41d11000 41d19000 r-xp /usr/lib/libdrm.so.2.4.0
41d21000 41d23000 r-xp /usr/lib/libdri2.so.0.0.0
41d2b000 41d31000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d39000 41d3e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d46000 41d5f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43600000 43621000 r-xp /usr/lib/libexif.so.12.3.3
43634000 43636000 r-xp /usr/lib/libttrace.so.1.1
4363e000 43643000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4364b000 43651000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4365a000 43662000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4366a000 4368c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43695000 4369c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436a5000 436a7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436af000 436b6000 r-xp /usr/lib/libminizip.so.1.0.0
436be000 436cb000 r-xp /usr/lib/libail.so.0.1.0
436d4000 436da000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e2000 436e3000 r-xp /usr/lib/libresponse.so.0.2.96
436eb000 436f0000 r-xp /usr/lib/libsystem.so.0.0.0
436fa000 437c4000 r-xp /usr/lib/libCOREGL.so.4.0
43c69000 43c74000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c7d000 43c82000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c8a000 43ca1000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43cae000 43cb0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cb9000 444b8000 rw-p [stack:5001]
444b8000 444b9000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444cf000 444d0000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444ee000 444f6000 r-xp /usr/lib/libfeedback.so.0.1.4
44acb000 44acc000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44ad4000 44ad6000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44ade000 44ae9000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44af1000 44af8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44b00000 44b18000 r-xp /usr/lib/libmmfsound.so.0.1.0
44b29000 44b2d000 r-xp /usr/lib/libmmfsession.so.0.0.0
44b36000 44b41000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44b4e000 44b52000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44b5a000 44b70000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44b78000 44bd9000 r-xp /usr/lib/libasound.so.2.0.0
44be3000 44be6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44bee000 44c26000 r-xp /usr/lib/libpulse.so.0.16.2
44c27000 44c2a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44c32000 44c7a000 r-xp /usr/lib/libmdm.so.1.2.62
44c7b000 44c7e000 r-xp /usr/lib/libtinycompress.so.0.0.0
44c86000 44c8b000 r-xp /usr/lib/libjson.so.0.0.1
44c93000 44cdc000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44ce5000 44d2c000 r-xp /usr/lib/libsndfile.so.1.0.26
44d38000 44d47000 r-xp /usr/lib/libmdm-common.so.1.1.22
44d50000 44d72000 r-xp /usr/lib/libvorbis.so.0.4.3
44d7a000 44d7e000 r-xp /usr/lib/libogg.so.0.7.1
45087000 45886000 rw-p [stack:5032]
45887000 46086000 rw-p [stack:5033]
bef47000 bef68000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4807)
Call Stack Count: 18
 0: _IO_vfprintf + 0x184 (0x404bb054) [/lib/libc.so.6] + 0x3e054
 1: _IO_fprintf + 0x1c (0x404c4478) [/lib/libc.so.6] + 0x47478
 2: _data_collection + 0x2a (0x413c13d7) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x33d7
 3: _new_gyroscope_value + 0x86 (0x413c14ff) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x34ff
 4: (0x416de127) [/usr/lib/libcapi-system-sensor.so.0] + 0x9127
 5: (0x41734af0) [/usr/lib/libsensor.so.1] + 0x14af0
 6: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 7: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 8: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 9: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
10: (0x402fe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
11: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x116 (0x413bfd77) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1d77
15: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
16: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
17: app_pause + 0xb (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
ME  (  811): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:12:26.241+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-12 11:12:26.241+0800 W/W_HOME  (  811): rotary.c: rotary_deattach(156) > rotary_deattach:0x474c2038
07-12 11:12:26.241+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 11:12:26.241+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x474c2038, elm_layout, func : 0x4005653d
07-12 11:12:26.241+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-12 11:12:26.241+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-12 11:12:26.241+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 11:12:26.241+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e39b0, elm_box, _activated_obj : 0x474c2038, activated : 1
07-12 11:12:26.241+0800 I/efl-extension(  811): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 11:12:26.241+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 11:12:26.241+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-12 11:12:26.246+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-12 11:12:26.251+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(811) status(bg) type(uiapp)
07-12 11:12:26.251+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[811] goes to (4)
07-12 11:12:26.251+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 811)'s state(4)
07-12 11:12:26.251+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4798] goes to (3)
07-12 11:12:26.251+0800 W/AUL_AMD (  524): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-12 11:12:26.251+0800 W/AUL_AMD (  524): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-12 11:12:26.251+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(4798) status(fg) type(uiapp)
07-12 11:12:26.261+0800 I/APP_CORE( 4798): appcore-efl.c: __do_app(453) > [APP 4798] Event: RESUME State: RUNNING
07-12 11:12:26.271+0800 W/W_HOME  (  811): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-12 11:12:26.271+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 11:12:26.271+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 11:12:26.271+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 11:12:26.271+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-12 11:12:26.271+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-12 11:12:26.271+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 11:12:26.271+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 11:12:26.271+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-12 11:12:26.281+0800 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-12 11:12:26.281+0800 E/CAPI_APPFW_APP_CONTROL( 1005): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-12 11:12:26.281+0800 W/MUSIC_CONTROL_SERVICE( 1005): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1005]   [com.samsung.w-home]register msg port [false][0m
07-12 11:12:26.286+0800 W/W_HOME  (  811): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
07-12 11:12:26.286+0800 W/W_HOME  (  811): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-12 11:12:26.291+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: PAUSE State: RUNNING
07-12 11:12:26.291+0800 I/CAPI_APPFW_APPLICATION(  811): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-12 11:12:26.291+0800 W/W_HOME  (  811): main.c: _appcore_pause_cb(487) > appcore pause
07-12 11:12:26.291+0800 E/W_HOME  (  811): main.c: _pause_cb(465) > paused already
07-12 11:12:26.296+0800 I/wnotib  (  811): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-12 11:12:26.296+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-12 11:12:26.296+0800 E/wnotib  (  811): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-12 11:12:26.296+0800 W/wnotib  (  811): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-12 11:12:26.326+0800 W/APPS    (  811): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-12 11:12:26.656+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 11:12:26.706+0800 I/MALI    ( 4798): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414600b8] swap changed from async to sync
07-12 11:12:26.786+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 11:12:26.961+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:12:26.976+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4798
07-12 11:12:26.976+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:12:27.001+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:12:27.011+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4798
07-12 11:12:27.011+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:12:27.346+0800 I/efl-extension( 4987): efl_extension.c: eext_mod_init(40) > Init
07-12 11:12:27.426+0800 I/UXT     ( 4987): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 11:12:27.521+0800 E/EFL     ( 4798): ecore_x<4798> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2673957 button=1
07-12 11:12:27.521+0800 E/EFL     ( 4798): elementary<4798> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4506e9f0 : elm_scroller] mouse move
07-12 11:12:27.531+0800 E/EFL     ( 4798): elementary<4798> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4506e9f0 : elm_scroller] mouse move
07-12 11:12:27.531+0800 E/EFL     ( 4798): elementary<4798> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4506e9f0 : elm_scroller] hold(0), freeze(0)
07-12 11:12:27.541+0800 E/EFL     ( 4798): ecore_x<4798> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2673978 button=1
07-12 11:12:27.556+0800 I/AUL_PAD ( 4987): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-12 11:12:27.561+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:12:27.571+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
07-12 11:12:27.571+0800 W/AUL     ( 4798): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-12 11:12:27.576+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 0
07-12 11:12:27.576+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(1782) > caller pid : 4798
07-12 11:12:27.576+0800 I/AUL_AMD (  524): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-12 11:12:27.591+0800 W/AUL_AMD (  524): amd_launch.c: _start_app(2218) > pad pid(-5)
07-12 11:12:27.591+0800 W/AUL_PAD ( 1308): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-12 11:12:27.591+0800 W/AUL_PAD ( 1308): launchpad.c: __send_result_to_caller(272) > Check app launching
07-12 11:12:27.596+0800 E/RESOURCED(  600): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-12 11:12:27.596+0800 W/AUL_PAD ( 4807): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-12 11:12:27.596+0800 W/AUL_PAD ( 4807): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-12 11:12:27.596+0800 W/AUL_PAD ( 4807): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-12 11:12:27.596+0800 W/AUL_PAD ( 4807): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-12 11:12:27.606+0800 E/MALI    ( 4987): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-12 11:12:27.606+0800 E/MALI    ( 4987): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-12 11:12:27.606+0800 E/MALI    ( 4987): [gpu-ddk] devel/graphics_drv/r4p0
07-12 11:12:27.606+0800 E/MALI    ( 4987): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-12 11:12:27.606+0800 E/MALI    ( 4987): [coregl] devel/graphics_engine/master
07-12 11:12:27.606+0800 E/MALI    ( 4987): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-12 11:12:27.606+0800 E/MALI    ( 4987): Ð
07-12 11:12:27.651+0800 I/efl-extension( 4807): efl_extension.c: eext_mod_init(40) > Init
07-12 11:12:27.656+0800 I/UXT     ( 4807): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-12 11:12:27.671+0800 W/AUL_PAD ( 4807): launchpad_loader.c: main(690) > [candidate] dlsym
07-12 11:12:27.671+0800 W/AUL_PAD ( 4807): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-12 11:12:27.671+0800 I/CAPI_APPFW_APPLICATION( 4807): app_main.c: ui_app_main(704) > app_efl_main
07-12 11:12:27.676+0800 I/CAPI_APPFW_APPLICATION( 4807): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-12 11:12:27.696+0800 W/AUL     (  524): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(4807) type(uiapp) bg(0)
07-12 11:12:27.696+0800 W/AUL_AMD (  524): amd_status.c: __socket_monitor_cb(1277) > (4807) was created
07-12 11:12:27.696+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 11:12:27.696+0800 W/AUL     ( 4798): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4807)
07-12 11:12:27.696+0800 E/W_TASKMANAGER( 4798): task.c: taskmanager_launch_task_info(1075) > [taskmanager_launch_task_info:1075] _launch_app() failed(4807)
07-12 11:12:27.721+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [4807]
07-12 11:12:27.876+0800 I/efl-extension( 4807): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 11:12:27.876+0800 I/efl-extension( 4807): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-12 11:12:27.876+0800 I/efl-extension( 4807): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-12 11:12:27.881+0800 I/efl-extension( 4807): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-12 11:12:27.881+0800 I/efl-extension( 4807): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44505728, elm_image, _activated_obj : 0x0, activated : 1
07-12 11:12:27.886+0800 E/EFL     ( 4807): elementary<4807> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 11:12:27.891+0800 E/EFL     ( 4807): elementary<4807> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44505b90) will be pushed
07-12 11:12:27.891+0800 I/efl-extension( 4807): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x43870950]'s widget[0x44507020] to layout widget[0x44505b90]
07-12 11:12:27.896+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437da910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 11:12:27.896+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437da910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-12 11:12:27.896+0800 I/efl-extension( 4807): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 11:12:27.906+0800 I/APP_CORE( 4807): appcore-efl.c: __do_app(453) > [APP 4807] Event: RESET State: CREATED
07-12 11:12:27.906+0800 I/CAPI_APPFW_APPLICATION( 4807): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-12 11:12:27.921+0800 I/APP_CORE( 4807): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-12 11:12:27.921+0800 I/APP_CORE( 4807): appcore-efl.c: __do_app(524) > [APP 4807] Initial Launching, call the resume_cb
07-12 11:12:27.921+0800 I/CAPI_APPFW_APPLICATION( 4807): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-12 11:12:27.961+0800 I/MALI    ( 4798): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414600b8] swap changed from sync to async
07-12 11:12:27.976+0800 W/APP_CORE( 4807): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4400002
07-12 11:12:27.976+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437da910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 11:12:27.976+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437da910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-12 11:12:28.021+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437da910 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-12 11:12:28.021+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437da910 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-12 11:12:28.106+0800 I/APP_CORE( 4807): appcore-efl.c: __do_app(453) > [APP 4807] Event: RESUME State: RUNNING
07-12 11:12:28.116+0800 I/APP_CORE( 4798): appcore-efl.c: __do_app(453) > [APP 4798] Event: PAUSE State: RUNNING
07-12 11:12:28.116+0800 I/CAPI_APPFW_APPLICATION( 4798): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-12 11:12:28.116+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(4798) status(bg) type(uiapp)
07-12 11:12:28.116+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4798] goes to (4)
07-12 11:12:28.131+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4807] goes to (3)
07-12 11:12:28.131+0800 W/AUL     (  524): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(4807) status(fg) type(uiapp)
07-12 11:12:28.316+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 22
07-12 11:12:28.316+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(999) > app status : 4
07-12 11:12:28.321+0800 E/APP_CORE( 4798): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
07-12 11:12:28.321+0800 I/APP_CORE( 4798): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
07-12 11:12:28.321+0800 I/CAPI_APPFW_APPLICATION( 4798): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
07-12 11:12:28.321+0800 I/efl-extension( 4798): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x4506e9f0, obj: 0x4506e9f0
07-12 11:12:28.321+0800 I/efl-extension( 4798): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
07-12 11:12:28.321+0800 I/efl-extension( 4798): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
07-12 11:12:28.321+0800 I/efl-extension( 4798): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
07-12 11:12:28.321+0800 I/efl-extension( 4798): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-12 11:12:28.326+0800 E/EFL     ( 4798): elementary<4798> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4506e9f0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-12 11:12:28.326+0800 E/EFL     ( 4798): elementary<4798> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4506e9f0 : elm_scroller] cw(0), ch(0), pw(360), ph(360)
07-12 11:12:28.326+0800 E/EFL     ( 4798): elementary<4798> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x4506e9f0 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-12 11:12:28.326+0800 I/efl-extension( 4798): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x4508c250
07-12 11:12:28.326+0800 I/efl-extension( 4798): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-12 11:12:28.326+0800 I/efl-extension( 4798): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x450b19d0 is freed
07-12 11:12:28.331+0800 I/efl-extension( 4798): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 11:12:28.331+0800 I/efl-extension( 4798): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4506e9f0, elm_scroller, func : 0x43912351
07-12 11:12:28.331+0800 I/efl-extension( 4798): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 11:12:28.331+0800 I/efl-extension( 4798): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-12 11:12:28.331+0800 I/efl-extension( 4798): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4508c250, elm_image, func : 0x43912351
07-12 11:12:28.331+0800 I/efl-extension( 4798): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-12 11:12:28.331+0800 I/efl-extension( 4798): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0x4506e9f0 : elm_scroller] rotary callabck is deleted
07-12 11:12:28.366+0800 E/TBM     (  397): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:397] error(Device or resource busy) _tgl_destroy:141 key:27
07-12 11:12:28.516+0800 E/TBM     (  397): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:397] error(Device or resource busy) _tgl_destroy:141 key:29
07-12 11:12:28.516+0800 E/AUL     (  524): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-12 11:12:28.546+0800 I/APP_CORE( 4798): appcore-efl.c: __after_loop(1243) > [APP 4798] After terminate() callback
07-12 11:12:28.596+0800 I/MALI    ( 4798): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
07-12 11:12:28.596+0800 I/MALI    ( 4798): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=4798   close drm_fd=23 
07-12 11:12:28.596+0800 I/MALI    ( 4798): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
07-12 11:12:28.711+0800 E/EFL     ( 4807): ecore_x<4807> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2675143 button=1
07-12 11:12:28.711+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.721+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.721+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.726+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.731+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.736+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.736+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.746+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.746+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.756+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.756+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.756+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] add hold animator
07-12 11:12:28.766+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x437da910 : elm_genlist] direction_x(0), direction_y(1)
07-12 11:12:28.766+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x437da910 : elm_genlist] drag_child_locked_y(0)
07-12 11:12:28.766+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x437da910 : elm_genlist] move content x(0), y(38)
07-12 11:12:28.836+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:12:28.846+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4807
07-12 11:12:28.846+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 14
07-12 11:12:28.856+0800 W/AUL_AMD (  524): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4807
07-12 11:12:28.856+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:12:28.861+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 12
07-12 11:12:28.876+0800 E/EFL     ( 4807): ecore_x<4807> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2675269 button=1
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:28.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:28.921+0800 I/UXT     ( 4798): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
07-12 11:12:28.921+0800 I/UXT     ( 4798): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
07-12 11:12:28.921+0800 I/UXT     ( 4798): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
07-12 11:12:29.161+0800 I/AUL_PAD ( 4996): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-12 11:12:29.226+0800 W/AUL_PAD ( 4798): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
07-12 11:12:29.226+0800 I/efl-extension( 4798): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-12 11:12:29.261+0800 E/EFL     ( 4807): ecore_x<4807> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2675681 button=1
07-12 11:12:29.261+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.261+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.261+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.266+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.266+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.276+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.276+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.291+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.291+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.301+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.301+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.311+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.311+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.311+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] add hold animator
07-12 11:12:29.316+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x437da910 : elm_genlist] direction_x(0), direction_y(1)
07-12 11:12:29.316+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x437da910 : elm_genlist] drag_child_locked_y(0)
07-12 11:12:29.316+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x437da910 : elm_genlist] move content x(0), y(274)
07-12 11:12:29.381+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4798 pgid = 4798
07-12 11:12:29.381+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
07-12 11:12:29.446+0800 W/AUL_PAD ( 1308): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-12 11:12:29.451+0800 I/AUL_AMD (  524): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4798
07-12 11:12:29.451+0800 W/AUL     (  524): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4798)
07-12 11:12:29.621+0800 E/EFL     ( 4807): ecore_x<4807> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2675801 button=1
07-12 11:12:29.621+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.621+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.621+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.621+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.621+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.621+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.621+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.621+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.751+0800 E/EFL     ( 4807): ecore_x<4807> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2676183 button=1
07-12 11:12:29.756+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.776+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.776+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.776+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.776+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.796+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] mouse move
07-12 11:12:29.796+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437da910 : elm_genlist] hold(0), freeze(0)
07-12 11:12:29.816+0800 E/EFL     ( 4807): ecore_x<4807> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2676237 button=1
07-12 11:12:29.861+0800 I/efl-extension( 4807): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 11:12:29.861+0800 I/efl-extension( 4807): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4386e338, elm_image, _activated_obj : 0x44505728, activated : 1
07-12 11:12:29.861+0800 I/efl-extension( 4807): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 11:12:29.876+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447f7b30 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-12 11:12:29.881+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447f7b30 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-12 11:12:29.901+0800 E/EFL     ( 4807): elementary<4807> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 11:12:29.906+0800 E/EFL     ( 4807): elementary<4807> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x447fba90) will be pushed
07-12 11:12:29.906+0800 I/efl-extension( 4807): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44db15f8]'s widget[0x44da80c0] to layout widget[0x447fba90]
07-12 11:12:29.911+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447f7b30 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:12:29.911+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447f7b30 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:12:29.916+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447f7b30 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:12:29.916+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447f7b30 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:12:29.916+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x447f7b30 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:12:29.916+0800 E/EFL     ( 4807): elementary<4807> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x447f7b30 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:12:29.916+0800 I/efl-extension( 4807): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 11:12:29.951+0800 E/EFL     ( 4807): elementary<4807> elc_naviframe.c:2796 _push_transition_cb() item(0x447fba90) will transition
07-12 11:12:30.316+0800 W/AUL_AMD (  524): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
07-12 11:12:30.396+0800 E/EFL     ( 4807): elementary<4807> elc_naviframe.c:1193 _on_item_push_finished() item(0x44505b90) transition finished
07-12 11:12:30.396+0800 E/EFL     ( 4807): elementary<4807> elc_naviframe.c:1218 _on_item_show_finished() item(0x447fba90) transition finished
07-12 11:12:30.641+0800 E/EFL     ( 4807): ecore_x<4807> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2677072 button=1
07-12 11:12:30.696+0800 E/EFL     ( 4807): ecore_x<4807> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2677130 button=1
07-12 11:12:31.291+0800 I/APP_CORE(  811): appcore-efl.c: __do_app(453) > [APP 811] Event: MEM_FLUSH State: PAUSED
07-12 11:12:31.701+0800 E/EFL     (  397): ecore_x<397> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x4400002 time=2677130
07-12 11:12:31.701+0800 E/EFL     ( 4807): ecore_x<4807> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=2677130
07-12 11:12:31.706+0800 E/EFL     (  397): ecore_x<397> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=2677130
07-12 11:12:31.771+0800 W/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-12 11:12:31.771+0800 I/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-12 11:12:31.771+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:12:31.771+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:12:31.771+0800 I/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-12 11:12:31.786+0800 E/wnoti-service( 1046): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-12 11:12:31.786+0800 E/wnoti-service( 1046): wnoti-native-client.c: handle_cache_notification(737) > >>
07-12 11:12:31.791+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-12 11:12:31.796+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-12 11:12:31.796+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-12 11:12:31.796+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-12 11:12:31.796+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-12 11:12:31.796+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 11:12:31.831+0800 E/ALARM_MANAGER(  506): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(12-7-2017, 11:12:37), repeat(0), interval(0), type(-1073741822)
07-12 11:12:31.836+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [506].
07-12 11:12:31.861+0800 I/AUL     (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 11:12:31.861+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 15
07-12 11:12:31.871+0800 W/SHealthService( 1107): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-12 11:12:31.876+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 11:12:31.891+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 11:12:31.891+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499829157, Wed Jul 12 11:12:37 2017
07-12 11:12:31.891+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 12536062, next duetime: 1499829157
07-12 11:12:31.891+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(12536062)
07-12 11:12:31.891+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499831948), due_time(1499829157)
07-12 11:12:31.901+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 11:12:31.901+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 11:12:31.901+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 03:12:37 (UTC).
07-12 11:12:31.901+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 11:12:31.901+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:12:31.906+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 11:12:31.906+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:12:31.916+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:385> }
07-12 11:12:31.916+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:531> }
07-12 11:12:33.641+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:12:33.791+0800 E/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-12 11:12:33.796+0800 W/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-12 11:12:33.881+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:12:33.891+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:12:33.901+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 11:12:33.921+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-12 11:12:33.926+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 11:12:33.936+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:12:33.951+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:12:36.996+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-12 11:12:37.126+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 11:12:37.186+0800 W/AUL     (  518): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(506) type(wakeup)
07-12 11:12:37.186+0800 E/RESOURCED(  600): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 506
07-12 11:12:37.206+0800 E/ALARM_MANAGER(  506): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [12536062]
07-12 11:12:37.206+0800 W/WECONN  (  506): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-12 11:12:37.206+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 11:12:37.206+0800 W/WECONN  (  506): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-12 11:12:37.206+0800 W/WECONN  (  506): <__connect_for_auto_switch:1706> { device=0x42903930, device->bt_address=1E:F0
07-12 11:12:37.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_expired(1445) > alarm_id[12536062] is expired.
07-12 11:12:37.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:12:37.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(12536062)
07-12 11:12:37.231+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1591639436) is OVER.
07-12 11:12:37.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 11:12:37.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 03:59:08 (UTC).
07-12 11:12:37.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 11:12:37.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:12:37.231+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-12 11:12:37.266+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 11:12:37.381+0800 W/WECONN  (  506): <__connect_for_auto_switch:1719> }
07-12 11:12:37.381+0800 W/WECONN  (  506):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-12 11:12:37.381+0800 W/WECONN  (  506): <__wc_device_try_to_connect_on_wear:185> }
07-12 11:12:42.566+0800 W/WECONN  (  506): <__on_connect_socket:378> {
07-12 11:12:42.566+0800 W/WECONN  (  506): <__is_device_matched_to:2560> le : , br_edr : 1E:F0, identifier : 1E:F0
07-12 11:12:42.566+0800 W/WECONN  (  506): <__on_connect_socket:383> result(-29359863), state(0)
07-12 11:12:42.566+0800 W/WECONN  (  506): <__on_connect_socket:387> }
07-12 11:12:49.261+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 4807(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-12-11--12-acc.txt
07-12 11:12:49.276+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 4807(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-12-11--12-gyr.txt
07-12 11:12:50.456+0800 W/CRASH_MANAGER( 5069): worker.c: worker_job(1205) > 110480773656e149982916
