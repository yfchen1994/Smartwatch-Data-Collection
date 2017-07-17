S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 3562
Date: 2017-07-15 23:34:08+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3562, uid 5000)

Register Information
r0   = 0xffffffff, r1   = 0x00000001
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xffffffff, r5   = 0x449ee848
r6   = 0x403866a8, r7   = 0x401f15c0
r8   = 0x000002a4, r9   = 0x401db9e0
r10  = 0x401dbaa4, fp   = 0x401db204
ip   = 0x40795d9c, sp   = 0xbeb62e68
lr   = 0x404ef5d0, pc   = 0x4036540a
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:      8176 KB
Buffers:     28476 KB
Cached:     144720 KB
VmPeak:     109592 KB
VmSize:     108064 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25636 KB
VmRSS:       25632 KB
VmData:      44520 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3562 TID = 3562
3562 3687 3736 3737 3738 

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
4190e000 41a43000 rw-p [heap]
41a43000 41a46000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a4e000 41a4f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a58000 41be0000 r-xp /usr/lib/libicui18n.so.57.1
41bf0000 41cf6000 r-xp /usr/lib/libicuuc.so.57.1
41d0c000 41d14000 r-xp /usr/lib/libdrm.so.2.4.0
41d1c000 41d1e000 r-xp /usr/lib/libdri2.so.0.0.0
41d26000 41d2c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d34000 41d39000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d41000 41d5a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
435fb000 4361c000 r-xp /usr/lib/libexif.so.12.3.3
4362f000 43631000 r-xp /usr/lib/libttrace.so.1.1
43639000 4363e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43646000 4364c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43655000 4365d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43665000 43687000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43690000 43697000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436a0000 436a2000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436aa000 436b1000 r-xp /usr/lib/libminizip.so.1.0.0
436b9000 436c6000 r-xp /usr/lib/libail.so.0.1.0
436cf000 436d5000 r-xp /usr/lib/libproc-stat.so.0.2.96
436dd000 436de000 r-xp /usr/lib/libresponse.so.0.2.96
436e6000 436eb000 r-xp /usr/lib/libsystem.so.0.0.0
436f5000 437bf000 r-xp /usr/lib/libCOREGL.so.4.0
43c64000 43c6f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c78000 43c7d000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c85000 43c9c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43ca9000 43cab000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cb4000 444b3000 rw-p [stack:3687]
444b3000 444b4000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444ce000 444cf000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444ed000 444f5000 r-xp /usr/lib/libfeedback.so.0.1.4
444f7000 444f8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
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
44f3d000 4573c000 rw-p [stack:3736]
4573d000 45f3c000 rw-p [stack:3737]
45f3d000 46ad5000 rw-p [stack:3738]
beb43000 beb64000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3562)
Call Stack Count: 29
 0: (0x4036540a) [/usr/lib/libedje.so.1] + 0x4540a
 1: (0x4036af83) [/usr/lib/libedje.so.1] + 0x4af83
 2: (0x40234ff3) [/usr/lib/libevas.so.1] + 0x35ff3
 3: evas_object_del + 0x194 (0x4022dd39) [/usr/lib/libevas.so.1] + 0x2ed39
 4: (0x401a4a4f) [/usr/lib/libelementary.so.1] + 0xf8a4f
 5: (0x4015f951) [/usr/lib/libelementary.so.1] + 0xb3951
 6: (0x40234ff3) [/usr/lib/libevas.so.1] + 0x35ff3
 7: evas_object_del + 0x194 (0x4022dd39) [/usr/lib/libevas.so.1] + 0x2ed39
 8: (0x401a4a4f) [/usr/lib/libelementary.so.1] + 0xf8a4f
 9: (0x4015f951) [/usr/lib/libelementary.so.1] + 0xb3951
10: (0x40234ff3) [/usr/lib/libevas.so.1] + 0x35ff3
11: evas_object_del + 0x194 (0x4022dd39) [/usr/lib/libevas.so.1] + 0x2ed39
12: _elm_widget_item_free + 0x76 (0x401a93ef) [/usr/lib/libelementary.so.1] + 0xfd3ef
13: (0x4015c9b5) [/usr/lib/libelementary.so.1] + 0xb09b5
14: (0x40365f0d) [/usr/lib/libedje.so.1] + 0x45f0d
15: (0x40369efd) [/usr/lib/libedje.so.1] + 0x49efd
16: (0x40366869) [/usr/lib/libedje.so.1] + 0x46869
17: (0x40366c1b) [/usr/lib/libedje.so.1] + 0x46c1b
18: (0x40366d55) [/usr/lib/libedje.so.1] + 0x46d55
19: (0x402fd3f5) [/usr/lib/libecore.so.1] + 0xb3f5
20: (0x402fae53) [/usr/lib/libecore.so.1] + 0x8e53
21: (0x402fe46b) [/usr/lib/libecore.so.1] + 0xc46b
22: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
23: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
24: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
25: main + 0x11a (0x413c0293) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x2293
26: (0x40001a53) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1a53
27: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
28: _single_line_entry_cb + 0x13 (0x40001e0c) [/opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection] + 0x1e0c
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
key_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-15 23:32:07.990+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-15 23:32:07.990+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-15 23:32:07.990+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-15 23:32:07.990+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-15 23:32:07.990+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-15 23:32:07.990+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-15 23:32:07.990+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-15 23:32:07.990+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-15 23:32:07.995+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(809) status(bg) type(uiapp)
07-15 23:32:07.995+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 23:32:07.995+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 23:32:07.995+0800 W/AUL_AMD (  520): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-15 23:32:07.995+0800 W/AUL_AMD (  520): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-15 23:32:08.000+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(3562) status(fg) type(uiapp)
07-15 23:32:08.000+0800 W/STARTER (  771): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[809] goes to (4)
07-15 23:32:08.000+0800 E/STARTER (  771): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 809)'s state(4)
07-15 23:32:08.000+0800 W/STARTER (  771): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[3562] goes to (3)
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-15 23:32:08.000+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-15 23:32:08.000+0800 E/CAPI_APPFW_APP_CONTROL( 1006): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-15 23:32:08.000+0800 W/MUSIC_CONTROL_SERVICE( 1006): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1006]   [com.samsung.w-home]register msg port [false][0m
07-15 23:32:08.000+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-15 23:32:08.005+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 1995
07-15 23:32:08.010+0800 I/wnotib  (  809): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-15 23:32:08.010+0800 E/wnotib  (  809): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-15 23:32:08.010+0800 W/wnotib  (  809): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-15 23:32:08.015+0800 W/WATCH_CORE(  930): appcore-watch.c: __widget_pause(1113) > widget_pause
07-15 23:32:08.015+0800 W/AUL     (  930): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(930) status(bg) type(watchapp)
07-15 23:32:08.015+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppPause(589) > 
07-15 23:32:08.085+0800 E/TBM     (  463): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:463] error(Device or resource busy) _tgl_destroy:141 key:31
07-15 23:32:08.090+0800 I/APP_CORE( 3562): appcore-efl.c: __do_app(453) > [APP 3562] Event: RESUME State: RUNNING
07-15 23:32:08.405+0800 E/AUL     (  520): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-15 23:32:08.510+0800 I/APP_CORE(  809): appcore-efl.c: __do_app(453) > [APP 809] Event: MEM_FLUSH State: PAUSED
07-15 23:32:08.945+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-15 23:32:08.955+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3562
07-15 23:32:08.960+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-15 23:32:08.985+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-15 23:32:08.995+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3562
07-15 23:32:09.000+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-15 23:32:09.250+0800 I/AUL_PAD ( 3669): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-15 23:32:12.200+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 23:32:13.020+0800 I/APP_CORE(  809): appcore-efl.c: __do_app(453) > [APP 809] Event: MEM_FLUSH State: PAUSED
07-15 23:32:17.964+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 23:32:18.230+0800 E/EFL     ( 3562): ecore_x<3562> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8801222 button=1
07-15 23:32:18.230+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] mouse move
07-15 23:32:18.230+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] mouse move
07-15 23:32:18.230+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] hold(0), freeze(0)
07-15 23:32:18.240+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] mouse move
07-15 23:32:18.240+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] hold(0), freeze(0)
07-15 23:32:18.250+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] mouse move
07-15 23:32:18.250+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] hold(0), freeze(0)
07-15 23:32:18.265+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] mouse move
07-15 23:32:18.265+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] hold(0), freeze(0)
07-15 23:32:18.285+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] mouse move
07-15 23:32:18.285+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d5910 : elm_genlist] hold(0), freeze(0)
07-15 23:32:18.295+0800 E/EFL     ( 3562): ecore_x<3562> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8801290 button=1
07-15 23:32:18.300+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d5910 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-15 23:32:18.300+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d5910 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-15 23:32:18.300+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x437d5910 : elm_genlist] x(0), y(130)
07-15 23:32:18.300+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x437d5910 : elm_genlist] t_in(0.300000), pos_x(0)
07-15 23:32:18.305+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x437d5910 : elm_genlist] t_in(0.300000), pos_y(130)
07-15 23:32:18.315+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d5910 : elm_genlist] time(0.118734)
07-15 23:32:18.315+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d5910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-15 23:32:18.315+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d5910 : elm_genlist] time(0.118734)
07-15 23:32:18.325+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d5910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(15)
07-15 23:32:18.590+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d5910 : elm_genlist] time(0.999543)
07-15 23:32:18.590+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x437d5910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(15)
07-15 23:32:18.590+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d5910 : elm_genlist] time(0.999543)
07-15 23:32:18.595+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x437d5910 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-15 23:32:18.630+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x437d5910 : elm_genlist] time(0.988848)
07-15 23:32:18.630+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x437d5910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(129)
07-15 23:32:18.630+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x437d5910 : elm_genlist] time(0.988848)
07-15 23:32:18.630+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x437d5910 : elm_genlist] animation stop!!
07-15 23:32:18.655+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 23:32:18.660+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x438b7f98, elm_image, _activated_obj : 0x44513928, activated : 1
07-15 23:32:18.660+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 23:32:18.675+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x438b6238 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 23:32:18.675+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x438b6238 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 23:32:18.695+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 23:32:18.705+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x449d8360) will be pushed
07-15 23:32:18.705+0800 I/efl-extension( 3562): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x449fd9f0]'s widget[0x449f8620] to layout widget[0x449d8360]
07-15 23:32:18.710+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x438b6238 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 23:32:18.710+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x438b6238 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 23:32:18.710+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x438b6238 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 23:32:18.710+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x438b6238 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 23:32:18.710+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x438b6238 : elm_scroller] mx(0), my(24), minx(0), miny(0), px(0), py(0)
07-15 23:32:18.710+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x438b6238 : elm_scroller] cw(260), ch(384), pw(260), ph(360)
07-15 23:32:18.715+0800 I/efl-extension( 3562): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 23:32:18.720+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x437d5910 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-15 23:32:18.755+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2796 _push_transition_cb() item(0x449d8360) will transition
07-15 23:32:18.980+0800 W/WATCH_CORE(  930): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-15 23:32:18.980+0800 I/WATCH_CORE(  930): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-15 23:32:18.980+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 23:32:18.980+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 23:32:18.980+0800 I/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-15 23:32:18.985+0800 E/wnoti-service( 1048): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-15 23:32:18.985+0800 E/wnoti-service( 1048): wnoti-native-client.c: handle_cache_notification(737) > >>
07-15 23:32:18.985+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-15 23:32:18.985+0800 W/WECONN  (  500): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-15 23:32:18.985+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-15 23:32:18.985+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-15 23:32:18.985+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-15 23:32:18.985+0800 W/WECONN  (  500): <wc_manager_get_bearer_state:988> type : 1
07-15 23:32:18.995+0800 E/ALARM_MANAGER(  500): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(15-7-2017, 23:32:24), repeat(0), interval(0), type(-1073741822)
07-15 23:32:19.000+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [500].
07-15 23:32:19.030+0800 I/AUL     (  514): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-15 23:32:19.030+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 15
07-15 23:32:19.040+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-15 23:32:19.055+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-15 23:32:19.055+0800 E/ALARM_MANAGER(  514): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1500132744, Sat Jul 15 23:32:24 2017
07-15 23:32:19.055+0800 E/ALARM_MANAGER(  514): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 611660369, next duetime: 1500132744
07-15 23:32:19.055+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(611660369)
07-15 23:32:19.055+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1500134348), due_time(1500132744)
07-15 23:32:19.065+0800 W/SHealthService( 1167): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-15 23:32:19.070+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-15 23:32:19.070+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-15 23:32:19.070+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 15-7-2017, 15:32:24 (UTC).
07-15 23:32:19.070+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-15 23:32:19.070+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-15 23:32:19.080+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-15 23:32:19.090+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-15 23:32:19.100+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:385> }
07-15 23:32:19.100+0800 W/WECONN  (  500): <__wc_feature_wearonoff_monitor_cb:531> }
07-15 23:32:19.165+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:1193 _on_item_push_finished() item(0x44513d90) transition finished
07-15 23:32:19.165+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:1218 _on_item_show_finished() item(0x449d8360) transition finished
07-15 23:32:19.305+0800 E/EFL     (  463): ecore_x<463> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x5200002 time=8801720
07-15 23:32:19.310+0800 E/EFL     ( 3562): ecore_x<3562> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=8801720
07-15 23:32:19.310+0800 E/EFL     (  463): ecore_x<463> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=8801720
07-15 23:32:20.545+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 23:32:20.625+0800 E/SHealthService( 1167): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-15 23:32:20.640+0800 W/SHealthService( 1167): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-15 23:32:20.765+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:32:20.790+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:32:20.820+0800 W/SHealthCommon( 1167): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1500076800000.000000[0;m
07-15 23:32:20.875+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-15 23:32:20.880+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-15 23:32:20.905+0800 I/HealthDataService(  990): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 23:32:20.940+0800 I/healthData( 1167): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 23:32:24.000+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-15 23:32:24.065+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-15 23:32:24.115+0800 W/AUL     (  514): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(500) type(wakeup)
07-15 23:32:24.120+0800 E/RESOURCED(  615): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 500
07-15 23:32:24.135+0800 E/ALARM_MANAGER(  500): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [611660369]
07-15 23:32:24.135+0800 W/WECONN  (  500): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-15 23:32:24.140+0800 W/WECONN  (  500): <wc_manager_get_bearer_state:988> type : 1
07-15 23:32:24.140+0800 W/WECONN  (  500): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-15 23:32:24.140+0800 W/WECONN  (  500): <__connect_for_auto_switch:1706> { device=0x428fdc90, device->bt_address=1E:F0
07-15 23:32:24.160+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_expired(1445) > alarm_id[611660369] is expired.
07-15 23:32:24.165+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-15 23:32:24.165+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(611660369)
07-15 23:32:24.165+0800 E/ALARM_MANAGER(  514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1591639436) is OVER.
07-15 23:32:24.170+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-15 23:32:24.170+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 15-7-2017, 15:59:08 (UTC).
07-15 23:32:24.170+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-15 23:32:24.170+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-15 23:32:24.170+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-15 23:32:24.200+0800 E/ALARM_MANAGER(  514): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-15 23:32:24.310+0800 W/WECONN  (  500): <__connect_for_auto_switch:1719> }
07-15 23:32:24.310+0800 W/WECONN  (  500):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-15 23:32:24.310+0800 W/WECONN  (  500): <__wc_device_try_to_connect_on_wear:185> }
07-15 23:32:29.480+0800 W/WECONN  (  500): <__on_connect_socket:378> {
07-15 23:32:29.480+0800 W/WECONN  (  500): <__is_device_matched_to:2560> le : , br_edr : 1E:F0, identifier : 1E:F0
07-15 23:32:29.480+0800 W/WECONN  (  500): <__on_connect_socket:383> result(-29359863), state(0)
07-15 23:32:29.480+0800 W/WECONN  (  500): <__on_connect_socket:387> }
07-15 23:32:30.545+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 23:33:00.820+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 23:33:00.890+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
07-15 23:33:00.895+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
07-15 23:33:00.895+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: preference_get_double(1214) > preference_get_double(1167) : pedometer_inactive_period error
07-15 23:33:00.895+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
07-15 23:33:00.895+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
07-15 23:33:00.900+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: preference_get_boolean(1173) > preference_get_boolean(1167) : inactive_test_mode_on error
07-15 23:33:00.900+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:33:00.940+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:33:21.019+0800 W/SHealthCommon( 1167): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1500076800000.000000[0;m
07-15 23:33:21.079+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-15 23:33:21.114+0800 I/HealthDataService(  990): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 23:33:21.149+0800 I/healthData( 1167): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 23:33:23.225+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 23:33:38.280+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 23:33:45.724+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-15 23:33:49.095+0800 W/WATCH_CORE(  930): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-15 23:33:49.095+0800 I/WATCH_CORE(  930): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-15 23:33:49.100+0800 I/CAPI_WATCH_APPLICATION(  930): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-15 23:33:49.100+0800 E/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(616) > 
07-15 23:33:49.100+0800 I/watchface-loader(  930): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-15 23:33:49.155+0800 E/wnoti-service( 1048): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 1 to 2 
07-15 23:33:49.175+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 1 -> 2
07-15 23:33:49.180+0800 W/WECONN  (  500): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
07-15 23:33:49.180+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_OFF
07-15 23:33:49.180+0800 W/WECONN  (  500): <__wc_device_on_wear_onoff_changed_cb:385> }
07-15 23:33:49.180+0800 W/WECONN  (  500): <__wc_feature_wearonoff_monitor_cb:531> }
07-15 23:33:49.210+0800 W/SHealthService( 1167): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
07-15 23:33:52.040+0800 E/EFL     ( 3562): ecore_x<3562> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8895031 button=1
07-15 23:33:52.095+0800 E/EFL     ( 3562): ecore_x<3562> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8895088 button=1
07-15 23:33:53.100+0800 E/EFL     (  463): ecore_x<463> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x5200002 time=8895088
07-15 23:33:53.110+0800 E/EFL     ( 3562): ecore_x<3562> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=8895088
07-15 23:33:53.115+0800 E/EFL     (  463): ecore_x<463> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=8895088
07-15 23:33:56.140+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 23:33:56.140+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x43887690, elm_image, _activated_obj : 0x438b7f98, activated : 1
07-15 23:33:56.145+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 23:33:56.175+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 23:33:56.175+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 23:33:56.180+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 23:33:56.205+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x438bb1a0) will be pushed
07-15 23:33:56.205+0800 I/efl-extension( 3562): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44a279d0]'s widget[0x44a23d10] to layout widget[0x438bb1a0]
07-15 23:33:56.215+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:33:56.220+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:33:56.220+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:33:56.220+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:33:56.220+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:33:56.230+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:33:56.235+0800 I/efl-extension( 3562): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 23:33:56.285+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2796 _push_transition_cb() item(0x438bb1a0) will transition
07-15 23:33:56.700+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:1193 _on_item_push_finished() item(0x449d8360) transition finished
07-15 23:33:56.700+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:1218 _on_item_show_finished() item(0x438bb1a0) transition finished
07-15 23:34:00.795+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 23:34:00.870+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
07-15 23:34:00.870+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
07-15 23:34:00.880+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: preference_get_double(1214) > preference_get_double(1167) : pedometer_inactive_period error
07-15 23:34:00.880+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
07-15 23:34:00.880+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
07-15 23:34:00.880+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1167): preference.c: preference_get_boolean(1173) > preference_get_boolean(1167) : inactive_test_mode_on error
07-15 23:34:00.895+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:00.930+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:05.710+0800 E/RESOURCED(  615): block-monitor.c: block_logging(123) > pid 3562(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/admin/2017-07-15-23--33-acc.txt
07-15 23:34:05.710+0800 E/RESOURCED(  615): block-monitor.c: block_logging(123) > pid 3562(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/admin/2017-07-15-23--33-gyr.txt
07-15 23:34:05.765+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-15 23:34:05.765+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x438bb1a0) will be popped.
07-15 23:34:05.785+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-15 23:34:05.785+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44a242f0, elm_image, _activated_obj : 0x43887690, activated : 1
07-15 23:34:05.790+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-15 23:34:05.805+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-15 23:34:05.805+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-15 23:34:05.810+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-15 23:34:05.825+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44a3b500) will be pushed
07-15 23:34:05.825+0800 I/efl-extension( 3562): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44a3f6e0]'s widget[0x44a36b78] to layout widget[0x44a3b500]
07-15 23:34:05.835+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:34:05.835+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:34:05.835+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:34:05.835+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:34:05.835+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:34:05.835+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] cw(260), ch(288), pw(260), ph(360)
07-15 23:34:05.835+0800 I/efl-extension( 3562): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-15 23:34:05.865+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2280 _pop_transition_cb() item(0x438bb1a0) will transition
07-15 23:34:05.870+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2796 _push_transition_cb() item(0x44a3b500) will transition
07-15 23:34:06.020+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 23:34:06.035+0800 W/SHealthService( 1167): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-15 23:34:06.065+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-15 23:34:06.095+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:06.110+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:06.130+0800 W/SHealthCommon( 1167): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1500076800000.000000[0;m
07-15 23:34:06.155+0800 I/HealthDataService(  990): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 23:34:06.175+0800 I/healthData( 1167): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 23:34:06.180+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-15 23:34:06.185+0800 I/HealthDataService(  990): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 23:34:06.210+0800 I/healthData( 1167): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 23:34:06.285+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:1274 _on_item_pop_finished() item(0x438bb1a0) transition finished
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x449f94d0, obj: 0x449f94d0
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x449f94d0, elm_scroller, func : 0x416fb351
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x43887690, elm_image, func : 0x416fb351
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0x449f94d0 : elm_scroller] rotary callabck is deleted
07-15 23:34:06.290+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:34:06.290+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x449f94d0 : elm_scroller] cw(0), ch(0), pw(260), ph(360)
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-15 23:34:06.290+0800 I/efl-extension( 3562): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x44a279d0 is freed
07-15 23:34:06.295+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:1193 _on_item_push_finished() item(0x449d8360) transition finished
07-15 23:34:06.295+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:1218 _on_item_show_finished() item(0x44a3b500) transition finished
07-15 23:34:06.520+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 23:34:06.570+0800 W/SHealthService( 1167): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-15 23:34:06.625+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-15 23:34:06.625+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:06.640+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:06.675+0800 I/HealthDataService(  990): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 23:34:06.705+0800 I/healthData( 1167): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 23:34:06.710+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 23:34:06.720+0800 W/SHealthService( 1167): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-15 23:34:06.745+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-15 23:34:06.745+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:06.755+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:06.770+0800 I/HealthDataService(  990): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 23:34:06.790+0800 I/healthData( 1167): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 23:34:08.050+0800 W/KEYROUTER(  463): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x5200002
07-15 23:34:08.055+0800 E/EFL     ( 3562): ecore_x<3562> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=8911012
07-15 23:34:08.190+0800 W/KEYROUTER(  463): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x5200002
07-15 23:34:08.195+0800 E/EFL     ( 3562): ecore_x<3562> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=8911182
07-15 23:34:08.195+0800 E/efl-extension( 3562): efl_extension_events.c: _eext_key_grab_rect_key_up_cb(240) > key up called
07-15 23:34:08.195+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-15 23:34:08.200+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x44a3b500) will be popped.
07-15 23:34:08.240+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:2280 _pop_transition_cb() item(0x44a3b500) will transition
07-15 23:34:08.660+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:1218 _on_item_show_finished() item(0x449d8360) transition finished
07-15 23:34:08.660+0800 E/EFL     ( 3562): elementary<3562> elc_naviframe.c:1274 _on_item_pop_finished() item(0x44a3b500) transition finished
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x44a24bc0, obj: 0x44a24bc0
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x44a242f0
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44a24bc0, elm_scroller, func : 0x416fb351
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44a242f0, elm_image, func : 0x416fb351
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-15 23:34:08.665+0800 I/efl-extension( 3562): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0x44a24bc0 : elm_scroller] rotary callabck is deleted
07-15 23:34:08.670+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-15 23:34:08.670+0800 E/EFL     ( 3562): elementary<3562> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44a24bc0 : elm_scroller] cw(0), ch(0), pw(260), ph(360)
07-15 23:34:08.690+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-15 23:34:08.710+0800 W/SHealthService( 1167): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-15 23:34:08.725+0800 W/SHealthCommon( 1167): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-15 23:34:08.725+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:08.745+0800 W/SHealthService( 1167): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-15 23:34:08.765+0800 I/HealthDataService(  990): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-15 23:34:08.780+0800 I/healthData( 1167): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-15 23:34:09.070+0800 W/AUL_PAD ( 1332): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3562 pgid = 3562
07-15 23:34:09.070+0800 W/AUL_PAD ( 1332): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-15 23:34:09.075+0800 W/CRASH_MANAGER( 3787): worker.c: worker_job(1205) > 110356273656e150013284
