S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 6669
Date: 2017-07-12 11:51:05+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 6669, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00001a0d
r2   = 0x00000006, r3   = 0x00001a0d
r4   = 0x00000006, r5   = 0x00000002
r6   = 0x405abbec, r7   = 0x0000010c
r8   = 0x00000038, r9   = 0x00000002
r10  = 0xbe99c0f8, fp   = 0xbe99c710
ip   = 0x4138e030, sp   = 0xbe99bfd8
lr   = 0x404ad328, pc   = 0x404a9668
cpsr = 0x20000010

Memory Information
MemTotal:   491132 KB
MemFree:     62452 KB
Buffers:     15996 KB
Cached:     130248 KB
VmPeak:     108804 KB
VmSize:     106768 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24312 KB
VmRSS:       24308 KB
VmData:      43232 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6669 TID = 6669
6669 6759 6783 6784 6785 

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
41535000 4153a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41542000 4154e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
41557000 41578000 r-xp /usr/lib/libefl-extension.so.0.1.0
41580000 41585000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4158d000 415b7000 r-xp /usr/lib/libsensor.so.1.9.5
415c0000 415c7000 r-xp /usr/lib/libctx-shared.so.0.8.3
415cf000 415d4000 r-xp /usr/lib/libctx-client.so.0.8.3
415e1000 41691000 rw-p [heap]
41924000 41936000 r-xp /usr/lib/libefl-assist.so.0.1.0
4193e000 419f6000 r-xp /usr/lib/libcairo.so.2.11200.14
41a01000 41a0b000 r-xp /usr/lib/libsensord-shared.so
41a13000 41a22000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a2b000 41a41000 r-xp /usr/lib/libtts.so
41a4a000 41a6d000 r-xp /usr/lib/libui-extension.so.0.1.0
41a76000 41a81000 r-xp /usr/lib/libtbm.so.1.0.0
41a89000 41a97000 r-xp /usr/lib/libGLESv2.so.2.0
41aa0000 41aa1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41aaa000 41ab0000 r-xp /usr/lib/libxcb-render.so.0.0.0
41ab8000 41abb000 r-xp /usr/lib/libEGL.so.1.4
41ac3000 41ac6000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41ace000 41acf000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41ad8000 41c60000 r-xp /usr/lib/libicui18n.so.57.1
41c70000 41d76000 r-xp /usr/lib/libicuuc.so.57.1
41d8c000 41d94000 r-xp /usr/lib/libdrm.so.2.4.0
41d9c000 41d9e000 r-xp /usr/lib/libdri2.so.0.0.0
41da6000 41dac000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41db4000 41db9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41dc1000 41dda000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4367b000 4369c000 r-xp /usr/lib/libexif.so.12.3.3
436af000 436b1000 r-xp /usr/lib/libttrace.so.1.1
436b9000 436be000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
436c6000 436cc000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
436d5000 436dd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
436e5000 43707000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43710000 43717000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43720000 43722000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4372a000 43731000 r-xp /usr/lib/libminizip.so.1.0.0
43739000 43746000 r-xp /usr/lib/libail.so.0.1.0
4374f000 43755000 r-xp /usr/lib/libproc-stat.so.0.2.96
4375d000 4375e000 r-xp /usr/lib/libresponse.so.0.2.96
43766000 4376b000 r-xp /usr/lib/libsystem.so.0.0.0
43775000 4383f000 r-xp /usr/lib/libCOREGL.so.4.0
43be4000 43bef000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43bf8000 43bfd000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c05000 43c1c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c29000 43c2b000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c34000 444b2000 rw-p [stack:6759]
444b2000 444b3000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444c9000 444ca000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444e8000 444f0000 r-xp /usr/lib/libfeedback.so.0.1.4
444f2000 444f3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44a4c000 44a4e000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44a56000 44a61000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44a69000 44a70000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44a78000 44a90000 r-xp /usr/lib/libmmfsound.so.0.1.0
44aa1000 44aa5000 r-xp /usr/lib/libmmfsession.so.0.0.0
44aae000 44ab9000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44ac6000 44aca000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44ad2000 44ae8000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44af0000 44b51000 r-xp /usr/lib/libasound.so.2.0.0
44b5b000 44b5e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44b66000 44b9e000 r-xp /usr/lib/libpulse.so.0.16.2
44b9f000 44ba2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44baa000 44bf2000 r-xp /usr/lib/libmdm.so.1.2.62
44bf3000 44bf6000 r-xp /usr/lib/libtinycompress.so.0.0.0
44bfe000 44c03000 r-xp /usr/lib/libjson.so.0.0.1
44c0b000 44c54000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44c5d000 44ca4000 r-xp /usr/lib/libsndfile.so.1.0.26
44cb0000 44cbf000 r-xp /usr/lib/libmdm-common.so.1.1.22
44cc8000 44cea000 r-xp /usr/lib/libvorbis.so.0.4.3
44cf2000 44cf6000 r-xp /usr/lib/libogg.so.0.7.1
4507e000 4587d000 rw-p [stack:6783]
4587e000 4607d000 rw-p [stack:6784]
4607e000 46a10000 rw-p [stack:6785]
be97d000 be99e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6669)
Call Stack Count: 2
 0: gsignal + 0x3c (0x404a9668) [/lib/libc.so.6] + 0x2c668
 1: (0x1) (null)
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
plied colors!
07-12 11:50:42.701+0800 E/EFL     ( 6669): evas_main<6669> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
07-12 11:50:42.701+0800 I/efl-extension( 6669): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 11:50:42.701+0800 I/efl-extension( 6669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44739e70, elm_image, _activated_obj : 0x445073b0, activated : 1
07-12 11:50:42.701+0800 I/efl-extension( 6669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 11:50:42.701+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 11:50:42.721+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4473a450) will be pushed
07-12 11:50:42.721+0800 I/efl-extension( 6669): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44820da0]'s widget[0x44d81528] to layout widget[0x4473a450]
07-12 11:50:42.726+0800 I/efl-extension( 6669): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 11:50:42.726+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x418a9cf0 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-12 11:50:42.766+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:2796 _push_transition_cb() item(0x4473a450) will transition
07-12 11:50:43.176+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:1193 _on_item_push_finished() item(0x44507818) transition finished
07-12 11:50:43.181+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:1218 _on_item_show_finished() item(0x4473a450) transition finished
07-12 11:50:43.366+0800 E/EFL     (  397): ecore_x<397> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1600002 time=4969172
07-12 11:50:43.371+0800 E/EFL     ( 6669): ecore_x<6669> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=4969172
07-12 11:50:43.371+0800 E/EFL     (  397): ecore_x<397> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=4969172
07-12 11:50:44.711+0800 W/KEYROUTER(  397): e_mod_main.c: DeliverDeviceKeyEvents(3157) > Deliver KeyPress. value=2669, window=0x1600002
07-12 11:50:44.716+0800 E/EFL     ( 6669): ecore_x<6669> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=4971122
07-12 11:50:44.856+0800 W/KEYROUTER(  397): e_mod_main.c: DeliverDeviceKeyEvents(3168) > Deliver KeyRelease. value=2669, window=0x1600002
07-12 11:50:44.861+0800 E/EFL     ( 6669): ecore_x<6669> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=4971286
07-12 11:50:44.861+0800 E/efl-extension( 6669): efl_extension_events.c: _eext_key_grab_rect_key_up_cb(240) > key up called
07-12 11:50:44.861+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:3136 elm_naviframe_item_pop() naviframe item pop
07-12 11:50:44.861+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:3149 elm_naviframe_item_pop() item(0x4473a450) will be popped.
07-12 11:50:44.861+0800 I/efl-extension( 6669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445073b0, elm_image, _activated_obj : 0x44739e70, activated : 1
07-12 11:50:44.861+0800 I/efl-extension( 6669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 11:50:44.931+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:2280 _pop_transition_cb() item(0x4473a450) will transition
07-12 11:50:45.366+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:1218 _on_item_show_finished() item(0x44507818) transition finished
07-12 11:50:45.371+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:1274 _on_item_pop_finished() item(0x4473a450) transition finished
07-12 11:50:45.371+0800 I/efl-extension( 6669): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x44739e70, obj: 0x44739e70
07-12 11:50:45.371+0800 I/efl-extension( 6669): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-12 11:50:45.376+0800 I/efl-extension( 6669): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-12 11:50:45.376+0800 I/efl-extension( 6669): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x44820da0 is freed
07-12 11:50:45.651+0800 E/EFL     ( 6669): ecore_x<6669> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4972081 button=1
07-12 11:50:45.651+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.651+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.651+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.661+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.661+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.671+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.671+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.686+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.686+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.696+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.696+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.696+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] add hold animator
07-12 11:50:45.696+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x418a9cf0 : elm_genlist] direction_x(0), direction_y(1)
07-12 11:50:45.696+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x418a9cf0 : elm_genlist] drag_child_locked_y(0)
07-12 11:50:45.701+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x418a9cf0 : elm_genlist] move content x(0), y(169)
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.751+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.756+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x418a9cf0 : elm_genlist] direction_x(0), direction_y(1)
07-12 11:50:45.756+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x418a9cf0 : elm_genlist] drag_child_locked_y(0)
07-12 11:50:45.756+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x418a9cf0 : elm_genlist] move content x(0), y(244)
07-12 11:50:45.796+0800 E/EFL     ( 6669): ecore_x<6669> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4972228 button=1
07-12 11:50:45.796+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.796+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.796+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.796+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:45.796+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:45.796+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:46.316+0800 E/EFL     ( 6669): ecore_x<6669> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4972750 button=1
07-12 11:50:46.316+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:46.361+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:46.361+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:46.401+0800 E/EFL     ( 6669): ecore_x<6669> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4972824 button=1
07-12 11:50:46.401+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] mouse move
07-12 11:50:46.401+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x418a9cf0 : elm_genlist] hold(0), freeze(0)
07-12 11:50:46.456+0800 I/efl-extension( 6669): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-12 11:50:46.461+0800 I/efl-extension( 6669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44d810c0, elm_image, _activated_obj : 0x445073b0, activated : 1
07-12 11:50:46.461+0800 I/efl-extension( 6669): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-12 11:50:46.471+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d80098 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-12 11:50:46.471+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d80098 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-12 11:50:46.481+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-12 11:50:46.491+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44739428) will be pushed
07-12 11:50:46.491+0800 I/efl-extension( 6669): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44db3780]'s widget[0x44dabc80] to layout widget[0x44739428]
07-12 11:50:46.491+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d80098 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:50:46.491+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d80098 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:50:46.491+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d80098 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:50:46.496+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d80098 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:50:46.496+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44d80098 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-12 11:50:46.496+0800 E/EFL     ( 6669): elementary<6669> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44d80098 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-12 11:50:46.496+0800 I/efl-extension( 6669): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-12 11:50:46.526+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:2796 _push_transition_cb() item(0x44739428) will transition
07-12 11:50:46.946+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:1193 _on_item_push_finished() item(0x44507818) transition finished
07-12 11:50:46.946+0800 E/EFL     ( 6669): elementary<6669> elc_naviframe.c:1218 _on_item_show_finished() item(0x44739428) transition finished
07-12 11:50:47.241+0800 E/EFL     ( 6669): ecore_x<6669> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4973673 button=1
07-12 11:50:47.321+0800 E/EFL     ( 6669): ecore_x<6669> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4973754 button=1
07-12 11:50:52.896+0800 W/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-12 11:50:52.896+0800 I/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-12 11:50:52.896+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:50:52.901+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:50:52.901+0800 I/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-12 11:50:52.931+0800 E/wnoti-service( 1046): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-12 11:50:52.931+0800 E/wnoti-service( 1046): wnoti-native-client.c: handle_cache_notification(737) > >>
07-12 11:50:52.961+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-12 11:50:52.996+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-12 11:50:52.996+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-12 11:50:52.996+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-12 11:50:52.996+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-12 11:50:52.996+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 11:50:53.031+0800 E/ALARM_MANAGER(  506): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(12-7-2017, 11:50:58), repeat(0), interval(0), type(-1073741822)
07-12 11:50:53.041+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [506].
07-12 11:50:53.076+0800 I/AUL     (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 11:50:53.081+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 15
07-12 11:50:53.106+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 11:50:53.121+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 11:50:53.121+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499831458, Wed Jul 12 11:50:58 2017
07-12 11:50:53.121+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 2143601053, next duetime: 1499831458
07-12 11:50:53.121+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(2143601053)
07-12 11:50:53.121+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499831948), due_time(1499831458)
07-12 11:50:53.141+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 11:50:53.146+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 11:50:53.146+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 03:50:58 (UTC).
07-12 11:50:53.146+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 11:50:53.146+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:50:53.156+0800 W/SHealthService( 1107): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-12 11:50:53.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 11:50:53.161+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:50:53.166+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:53.171+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:385> }
07-12 11:50:53.171+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:531> }
07-12 11:50:53.176+0800 E/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-12 11:50:53.186+0800 W/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-12 11:50:53.246+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:53.251+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:53.261+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 11:50:53.281+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-12 11:50:53.281+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 11:50:53.286+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:53.306+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:54.111+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:54.146+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:50:54.201+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:50:54.231+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:54.241+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:54.251+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 11:50:54.281+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:54.301+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:54.306+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 11:50:54.311+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:54.346+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:54.356+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:54.361+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:50:54.406+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:50:54.406+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:54.416+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:54.436+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:54.461+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:54.761+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:54.776+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:50:54.841+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:50:54.841+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:54.861+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:54.911+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:54.941+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:55.016+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:55.031+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:50:55.091+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:50:55.091+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:55.106+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:55.141+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:55.171+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:55.421+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:55.446+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:50:55.566+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:50:55.576+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:55.616+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:55.686+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:55.746+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:55.786+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:55.841+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:50:55.916+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:50:55.921+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:55.941+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:55.981+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:56.016+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:56.026+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:56.056+0800 E/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-12 11:50:56.066+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:56.086+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:56.111+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:56.126+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:56.151+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:56.181+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:56.191+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:50:56.251+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:50:56.251+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:56.266+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:56.296+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:56.321+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:56.746+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [4990][0;m
07-12 11:50:56.781+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:50:56.871+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:50:56.876+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:56.901+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:56.931+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:56.961+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:50:57.996+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-12 11:50:58.096+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 11:50:58.206+0800 W/AUL     (  518): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(506) type(wakeup)
07-12 11:50:58.206+0800 E/RESOURCED(  600): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 506
07-12 11:50:58.216+0800 E/ALARM_MANAGER(  506): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [2143601053]
07-12 11:50:58.216+0800 W/WECONN  (  506): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-12 11:50:58.216+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 11:50:58.216+0800 W/WECONN  (  506): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-12 11:50:58.216+0800 W/WECONN  (  506): <__connect_for_auto_switch:1706> { device=0x42903930, device->bt_address=1E:F0
07-12 11:50:58.236+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_expired(1445) > alarm_id[2143601053] is expired.
07-12 11:50:58.236+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:50:58.236+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(2143601053)
07-12 11:50:58.236+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1591639436) is OVER.
07-12 11:50:58.236+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 11:50:58.236+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 03:59:08 (UTC).
07-12 11:50:58.236+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 11:50:58.236+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:50:58.236+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-12 11:50:58.256+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 11:50:58.291+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:50:58.301+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:50:58.316+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:50:58.316+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:58.341+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:50:58.381+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:50:58.386+0800 W/WECONN  (  506): <__connect_for_auto_switch:1719> }
07-12 11:50:58.386+0800 W/WECONN  (  506):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-12 11:50:58.386+0800 W/WECONN  (  506): <__wc_device_try_to_connect_on_wear:185> }
07-12 11:50:58.396+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:51:00.381+0800 W/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-12 11:51:00.381+0800 I/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-12 11:51:00.386+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:51:00.386+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:51:00.386+0800 I/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-12 11:51:00.456+0800 E/wnoti-service( 1046): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 1 to 2 
07-12 11:51:00.511+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 1 -> 2
07-12 11:51:00.531+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
07-12 11:51:00.531+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_OFF
07-12 11:51:00.531+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:385> }
07-12 11:51:00.531+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:531> }
07-12 11:51:00.536+0800 W/SHealthService( 1107): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
07-12 11:51:03.261+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:51:03.321+0800 E/SHealthService( 1107): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-12 11:51:03.336+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.346+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.366+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:51:03.391+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:51:03.396+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:51:03.401+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:51:03.436+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:51:03.461+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.471+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.481+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:51:03.486+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
07-12 11:51:03.486+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
07-12 11:51:03.486+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
07-12 11:51:03.486+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
07-12 11:51:03.486+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
07-12 11:51:03.486+0800 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_boolean(1173) > preference_get_boolean(1107) : inactive_test_mode_on error
07-12 11:51:03.491+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.496+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.506+0800 W/SHealthCommon( 1107): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499817600000.000000[0;m
07-12 11:51:03.526+0800 W/WECONN  (  506): <__on_connect_socket:378> {
07-12 11:51:03.526+0800 W/WECONN  (  506): <__is_device_matched_to:2560> le : , br_edr : 1E:F0, identifier : 1E:F0
07-12 11:51:03.526+0800 W/WECONN  (  506): <__on_connect_socket:383> result(-29359863), state(0)
07-12 11:51:03.526+0800 W/WECONN  (  506): <__on_connect_socket:387> }
07-12 11:51:03.551+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:51:03.576+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:51:03.581+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:51:03.586+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:51:03.616+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:51:03.621+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.636+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.646+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-12 11:51:03.656+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:51:03.676+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:51:03.681+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:51:03.691+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:51:03.731+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:51:03.731+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.741+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:03.776+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:51:03.806+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:51:03.921+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:51:03.951+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:51:04.051+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:51:04.061+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:04.096+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:04.161+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:51:04.226+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:51:05.426+0800 W/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-12 11:51:05.426+0800 I/WATCH_CORE(  901): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-12 11:51:05.431+0800 I/CAPI_WATCH_APPLICATION(  901): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-12 11:51:05.431+0800 E/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(616) > 
07-12 11:51:05.431+0800 I/watchface-loader(  901): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-12 11:51:05.516+0800 E/wnoti-service( 1046): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-12 11:51:05.516+0800 E/wnoti-service( 1046): wnoti-native-client.c: handle_cache_notification(737) > >>
07-12 11:51:05.566+0800 E/WMS     (  521): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-12 11:51:05.586+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-12 11:51:05.586+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-12 11:51:05.591+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-12 11:51:05.591+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-12 11:51:05.591+0800 W/WECONN  (  506): <wc_manager_get_bearer_state:988> type : 1
07-12 11:51:05.616+0800 E/ALARM_MANAGER(  506): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(12-7-2017, 11:51:11), repeat(0), interval(0), type(-1073741822)
07-12 11:51:05.621+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [506].
07-12 11:51:05.656+0800 I/AUL     (  518): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 11:51:05.656+0800 W/AUL_AMD (  524): amd_request.c: __request_handler(669) > __request_handler: 15
07-12 11:51:05.681+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 11:51:05.696+0800 I/AUL_AMD (  524): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-12 11:51:05.696+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499831471, Wed Jul 12 11:51:11 2017
07-12 11:51:05.696+0800 E/ALARM_MANAGER(  518): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 645185293, next duetime: 1499831471
07-12 11:51:05.696+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(645185293)
07-12 11:51:05.696+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499831948), due_time(1499831471)
07-12 11:51:05.711+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-12 11:51:05.711+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-12 11:51:05.711+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-7-2017, 03:51:11 (UTC).
07-12 11:51:05.711+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-12 11:51:05.711+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:51:05.726+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-12 11:51:05.731+0800 E/ALARM_MANAGER(  518): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-12 11:51:05.741+0800 W/SHealthService( 1107): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-12 11:51:05.741+0800 W/WECONN  (  506): <__wc_device_on_wear_onoff_changed_cb:385> }
07-12 11:51:05.741+0800 W/WECONN  (  506): <__wc_feature_wearonoff_monitor_cb:531> }
07-12 11:51:05.951+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 6669(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/acc/2017-07-12-11--50-acc.txt
07-12 11:51:05.951+0800 E/RESOURCED(  600): block-monitor.c: block_logging(123) > pid 6669(org.example.sensordatacollection) accessed /opt/usr/media/Downloads/yfchen_sensor_data/gyr/2017-07-12-11--50-gyr.txt
07-12 11:51:06.016+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-12 11:51:06.041+0800 W/SHealthService( 1107): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
07-12 11:51:06.061+0800 W/SHealthCommon( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
07-12 11:51:06.066+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:06.091+0800 W/SHealthService( 1107): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-12 11:51:06.111+0800 I/HealthDataService(  993): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-12 11:51:06.136+0800 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-12 11:51:06.376+0800 W/CRASH_MANAGER( 6830): worker.c: worker_job(1205) > 060666973656e149983146
