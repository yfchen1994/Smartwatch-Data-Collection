S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 17378
Date: 2017-07-13 10:37:09+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 17378, uid 5000)

Register Information
r0   = 0xbe9b032d, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x445571a0, r5   = 0x445378c0
r6   = 0x44531820, r7   = 0xbe9b0010
r8   = 0x00000000, r9   = 0x446dad38
r10  = 0x447b3e98, fp   = 0x00000001
ip   = 0x414d1d9c, sp   = 0xbe9afff0
lr   = 0x414c0109, pc   = 0x404f2cb8
cpsr = 0x80000010

Memory Information
MemTotal:   491132 KB
MemFree:     30768 KB
Buffers:     10216 KB
Cached:     138528 KB
VmPeak:      96572 KB
VmSize:      95552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23708 KB
VmRSS:       23708 KB
VmData:      18476 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25500 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17378 TID = 17378
17378 17461 

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
414be000 414c2000 r-xp /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418c8000 418cd000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418d5000 418e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418ea000 4190b000 r-xp /usr/lib/libefl-extension.so.0.1.0
41913000 41918000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41920000 4194a000 r-xp /usr/lib/libsensor.so.1.9.5
41953000 4195a000 r-xp /usr/lib/libctx-shared.so.0.8.3
41962000 41967000 r-xp /usr/lib/libctx-client.so.0.8.3
4196f000 41981000 r-xp /usr/lib/libefl-assist.so.0.1.0
41989000 41a41000 r-xp /usr/lib/libcairo.so.2.11200.14
41a4c000 41a56000 r-xp /usr/lib/libsensord-shared.so
41a5e000 41a6d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a76000 41a8c000 r-xp /usr/lib/libtts.so
41a95000 41ab8000 r-xp /usr/lib/libui-extension.so.0.1.0
41ac1000 41acc000 r-xp /usr/lib/libtbm.so.1.0.0
41ad4000 41ae2000 r-xp /usr/lib/libGLESv2.so.2.0
41aeb000 41aec000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41af5000 41afb000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b03000 41b06000 r-xp /usr/lib/libEGL.so.1.4
41b0e000 41b11000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b19000 41b1a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b23000 41cab000 r-xp /usr/lib/libicui18n.so.57.1
41cbb000 41dc1000 r-xp /usr/lib/libicuuc.so.57.1
41dd7000 41ddf000 r-xp /usr/lib/libdrm.so.2.4.0
41de7000 41de9000 r-xp /usr/lib/libdri2.so.0.0.0
41df1000 41df7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41dff000 41e04000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41e0c000 41e25000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436c6000 436e7000 r-xp /usr/lib/libexif.so.12.3.3
436fa000 436fc000 r-xp /usr/lib/libttrace.so.1.1
43704000 43709000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43711000 43717000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43720000 43728000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43730000 43752000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4375b000 43762000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4376b000 4376d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43775000 4377c000 r-xp /usr/lib/libminizip.so.1.0.0
43784000 43791000 r-xp /usr/lib/libail.so.0.1.0
4379a000 437a0000 r-xp /usr/lib/libproc-stat.so.0.2.96
437a8000 437a9000 r-xp /usr/lib/libresponse.so.0.2.96
437b1000 437b6000 r-xp /usr/lib/libsystem.so.0.0.0
437c0000 4388a000 r-xp /usr/lib/libCOREGL.so.4.0
43c2f000 43c3a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c43000 43c48000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c50000 43c67000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c74000 43c76000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c7f000 4447e000 rw-p [stack:17461]
4447e000 4447f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44499000 4449a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444a5000 444aa000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
444b8000 444c0000 r-xp /usr/lib/libfeedback.so.0.1.4
444c2000 444c3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
444cb000 444cd000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
444d5000 444e0000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
444e8000 444ef000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44b4c000 44b64000 r-xp /usr/lib/libmmfsound.so.0.1.0
44b75000 44b79000 r-xp /usr/lib/libmmfsession.so.0.0.0
44b82000 44b8d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44b9a000 44b9e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44ba6000 44bbc000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44bc4000 44c25000 r-xp /usr/lib/libasound.so.2.0.0
44c2f000 44c32000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44c3a000 44c72000 r-xp /usr/lib/libpulse.so.0.16.2
44c73000 44c76000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44c7e000 44cc6000 r-xp /usr/lib/libmdm.so.1.2.62
44cc7000 44cca000 r-xp /usr/lib/libtinycompress.so.0.0.0
44cd2000 44cd7000 r-xp /usr/lib/libjson.so.0.0.1
44cdf000 44d28000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44d31000 44d78000 r-xp /usr/lib/libsndfile.so.1.0.26
44d84000 44d93000 r-xp /usr/lib/libmdm-common.so.1.1.22
44d9c000 44dbe000 r-xp /usr/lib/libvorbis.so.0.4.3
44dc6000 44dca000 r-xp /usr/lib/libogg.so.0.7.1
44dd2000 44de2000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
be990000 be9b1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17378)
Call Stack Count: 1
 0: strcmp + 0x4 (0x404f2cb8) [/lib/libc.so.6] + 0x75cb8
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
ve_event_cb() [0x4451d850 : elm_entry] mouse move
07-13 10:37:02.121+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4451d850 : elm_entry] hold(0), freeze(0)
07-13 10:37:02.131+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4451d850 : elm_entry] mouse move
07-13 10:37:02.131+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4451d850 : elm_entry] hold(0), freeze(0)
07-13 10:37:02.146+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=51906472 button=1
07-13 10:37:02.196+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [280x300]
07-13 10:37:02.206+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.206+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.211+0800 E/ISE_MULTI(  803): ise-ui.cpp: indicator_popup_show_cb(1533) > [0;31mindicator_popup_show_cb[0m
07-13 10:37:02.211+0800 E/AUL_AMD (  520): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
07-13 10:37:02.211+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[803] goes to (3)
07-13 10:37:02.241+0800 W/E17_EXTRA_MODULES(  462): e_mod_comp.c: _e_mod_comp_win_add(1704) > [CW Creating Fail!!(Attributes get)] Win:02800065, BD:(nil), POP:(nil), MENU:(nil)
07-13 10:37:02.351+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.356+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.356+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:02.356+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:02.376+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x22]
07-13 10:37:02.386+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=0[0m
07-13 10:37:02.386+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.386+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.426+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.426+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.426+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.426+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.441+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.441+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.441+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.441+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.441+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.441+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.446+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.446+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.451+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:02.451+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:02.456+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:02.456+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:02.456+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:02.456+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:02.461+0800 I/ISE_MULTI(  803): isemain.cpp: slot_reset_ise_input_context(1372) > [0;36m[hidden state:false][0m
07-13 10:37:02.541+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:37:02.541+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:37:02.566+0800 E/EFL     (17378): edje<17378> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:37:02.566+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4451baf0 : elm_scroller] mx(360), my(70), minx(0), miny(0), px(0), py(0)
07-13 10:37:02.566+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4451baf0 : elm_scroller] cw(360), ch(70), pw(0), ph(0)
07-13 10:37:02.566+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:37:02.566+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:37:03.146+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2800063 time=51906898
07-13 10:37:03.151+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=51906898
07-13 10:37:03.361+0800 E/ISE_HWR (  803): handwriting.cpp: __hwr_result_notification_callback(857) > [0;31m============iscommited == 1[0m
07-13 10:37:03.856+0800 I/efl-extension(17378): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:37:03.856+0800 I/efl-extension(17378): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x4187e060, elm_image, time_stamp : 51908184
07-13 10:37:03.856+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-13 10:37:03.856+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-13 10:37:03.856+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] x(0), y(130)
07-13 10:37:03.856+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x417e96d8 : elm_genlist] t_in(0.300000), pos_x(0)
07-13 10:37:03.856+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x417e96d8 : elm_genlist] t_in(0.300000), pos_y(130)
07-13 10:37:03.856+0800 I/efl-extension(  803): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:37:03.856+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: _ise_rotary_handler_cb(52) > [0;31m_ise_rotary_handler_cb[0m
07-13 10:37:03.861+0800 I/efl-extension(  806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:37:03.861+0800 I/efl-extension( 1316): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:37:03.861+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [65542][0m
07-13 10:37:03.871+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.107969)
07-13 10:37:03.871+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-13 10:37:03.871+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.107969)
07-13 10:37:03.876+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(14)
07-13 10:37:03.886+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.199050)
07-13 10:37:03.886+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(14)
07-13 10:37:03.886+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.199050)
07-13 10:37:03.911+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(25)
07-13 10:37:03.911+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.345721)
07-13 10:37:03.911+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(25)
07-13 10:37:03.911+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.345721)
07-13 10:37:03.961+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(44)
07-13 10:37:03.966+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.609322)
07-13 10:37:03.966+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(44)
07-13 10:37:03.966+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.609322)
07-13 10:37:03.971+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(79)
07-13 10:37:03.991+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.689269)
07-13 10:37:03.991+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(79)
07-13 10:37:03.991+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.689269)
07-13 10:37:03.991+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(89)
07-13 10:37:03.991+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.709475)
07-13 10:37:03.991+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(89)
07-13 10:37:03.991+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.709475)
07-13 10:37:03.996+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(92)
07-13 10:37:03.996+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.717814)
07-13 10:37:03.996+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(92)
07-13 10:37:03.996+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.717814)
07-13 10:37:03.996+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(93)
07-13 10:37:03.996+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.724752)
07-13 10:37:03.996+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(93)
07-13 10:37:03.996+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.724752)
07-13 10:37:04.011+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(94)
07-13 10:37:04.011+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.772114)
07-13 10:37:04.011+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(94)
07-13 10:37:04.011+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.772114)
07-13 10:37:04.011+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(100)
07-13 10:37:04.021+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.794335)
07-13 10:37:04.021+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(100)
07-13 10:37:04.021+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.794335)
07-13 10:37:04.021+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(103)
07-13 10:37:04.036+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.841663)
07-13 10:37:04.036+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(103)
07-13 10:37:04.036+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.841663)
07-13 10:37:04.036+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(109)
07-13 10:37:04.051+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.882881)
07-13 10:37:04.051+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(109)
07-13 10:37:04.051+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.882881)
07-13 10:37:04.056+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(114)
07-13 10:37:04.056+0800 E/ISE_MULTI(  803): rotary_input.cpp: destroy_rotary_input_layout(755) > [0;31mdestroy_rotary_input_layout[0m
07-13 10:37:04.056+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:37:04.056+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(335) > [0;36m----------START----------[0m
07-13 10:37:04.056+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(347) > [0;36m-------INPUT_MODE_HANDWRITING--------[0m
07-13 10:37:04.096+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(986) > [0;36m-----candidate_show-----[0m
07-13 10:37:04.096+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1008) > [0;36mcandidate_show:is_chinese = 1[0m
07-13 10:37:04.096+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1034) > [0;36m-----END-----[0m
07-13 10:37:04.096+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:37:04.101+0800 I/ISE_MULTI(  803): privatekeys.cpp: ise_update_globe_private_key(1819) > [0;36mSystem language is [zh_CN.UTF-8] #####[0m
07-13 10:37:04.116+0800 I/ISE_MULTI(  803): privatekeys.cpp: ise_update_globe_private_key(1819) > [0;36mSystem language is [zh_CN.UTF-8] #####[0m
07-13 10:37:04.146+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:37:04.151+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.999961)
07-13 10:37:04.156+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(114)
07-13 10:37:04.156+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.999961)
07-13 10:37:04.156+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(129)
07-13 10:37:04.161+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.999914)
07-13 10:37:04.161+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(129)
07-13 10:37:04.161+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.999914)
07-13 10:37:04.161+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] animation stop!!
07-13 10:37:04.161+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-13 10:37:04.191+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:04.191+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:04.206+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:04.206+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:04.206+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:04.206+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:04.211+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:04.211+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:05.131+0800 I/efl-extension(  803): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:37:05.131+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: _ise_rotary_handler_cb(52) > [0;31m_ise_rotary_handler_cb[0m
07-13 10:37:05.131+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [65543][0m
07-13 10:37:05.131+0800 I/efl-extension(  806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:37:05.131+0800 I/efl-extension( 1316): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:37:05.136+0800 I/efl-extension(17378): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:37:05.136+0800 I/efl-extension(17378): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x4187e060, elm_image, time_stamp : 51909458
07-13 10:37:05.146+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(130)
07-13 10:37:05.146+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-13 10:37:05.236+0800 I/ISE_MULTI(  803): privatekeys.cpp: ise_update_globe_private_key(1819) > [0;36mSystem language is [zh_CN.UTF-8] #####[0m
07-13 10:37:05.246+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:05.246+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:05.286+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:05.286+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:05.366+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: focus_in_timer(381) > [0;36mfocus_in_timer[0m
07-13 10:37:05.366+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: reload_config_thread(256) > [0;36mg_prediction_setting_value = [1], arg = [1], try--1[0m
07-13 10:37:06.086+0800 W/WATCH_CORE(  929): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-13 10:37:06.086+0800 I/WATCH_CORE(  929): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-13 10:37:06.086+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:37:06.086+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:37:06.086+0800 I/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-13 10:37:06.091+0800 E/wnoti-service( 1049): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-13 10:37:06.091+0800 E/wnoti-service( 1049): wnoti-native-client.c: handle_cache_notification(737) > >>
07-13 10:37:06.091+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-13 10:37:06.091+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-13 10:37:06.091+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-13 10:37:06.091+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-13 10:37:06.091+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-13 10:37:06.091+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-13 10:37:06.101+0800 E/ALARM_MANAGER(  499): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(13-7-2017, 10:37:11), repeat(0), interval(0), type(-1073741822)
07-13 10:37:06.106+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [499].
07-13 10:37:06.121+0800 I/AUL     (  516): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-13 10:37:06.121+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 15
07-13 10:37:06.136+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-13 10:37:06.146+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-13 10:37:06.146+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499913431, Thu Jul 13 10:37:11 2017
07-13 10:37:06.146+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 2056737168, next duetime: 1499913431
07-13 10:37:06.146+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(2056737168)
07-13 10:37:06.146+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499918348), due_time(1499913431)
07-13 10:37:06.156+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-13 10:37:06.156+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-13 10:37:06.156+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 13-7-2017, 02:37:11 (UTC).
07-13 10:37:06.156+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-13 10:37:06.156+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:37:06.166+0800 W/SHealthService( 1115): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-13 10:37:06.171+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-13 10:37:06.171+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:37:06.181+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:385> }
07-13 10:37:06.181+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:531> }
07-13 10:37:06.831+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Load_lang(1045) > [0;36mSuccessfully loaded DB : en_US[0m
07-13 10:37:06.876+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51911207 button=1
07-13 10:37:06.911+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [53][0m
07-13 10:37:06.926+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1
07-13 10:37:07.031+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51911362 button=1
07-13 10:37:07.061+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:37:07.066+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:37:07.066+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:37:07.076+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1
07-13 10:37:07.086+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.086+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.091+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.091+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.096+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.096+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.096+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:07.096+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:07.101+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [53][0m
07-13 10:37:07.106+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1
07-13 10:37:07.111+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=1[0m
07-13 10:37:07.181+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:37:07.186+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:37:07.186+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:37:07.186+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.186+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.191+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1
07-13 10:37:07.191+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.191+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.191+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.191+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.201+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:07.201+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:07.211+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51911531 button=1
07-13 10:37:07.211+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=2[0m
07-13 10:37:07.276+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [53][0m
07-13 10:37:07.281+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1
07-13 10:37:07.371+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51911700 button=1
07-13 10:37:07.381+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:37:07.381+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:37:07.381+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:37:07.386+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1
07-13 10:37:07.411+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.411+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:07.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:07.426+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=3[0m
07-13 10:37:07.436+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [55][0m
07-13 10:37:07.451+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1
07-13 10:37:07.521+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:37:07.521+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:37:07.521+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:37:07.526+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.526+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.531+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.531+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.531+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.531+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.536+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:07.536+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:07.541+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1
07-13 10:37:07.546+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=4[0m
07-13 10:37:07.556+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51911874 button=1
07-13 10:37:07.611+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [49][0m
07-13 10:37:07.616+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1
07-13 10:37:07.616+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1
07-13 10:37:07.726+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:37:07.731+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:37:07.731+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:37:07.731+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.736+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.736+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51912066 button=1
07-13 10:37:07.736+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.741+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.771+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.771+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.771+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:07.771+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:07.786+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=5[0m
07-13 10:37:07.801+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [53][0m
07-13 10:37:07.806+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1
07-13 10:37:07.876+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:37:07.881+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:37:07.881+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:37:07.881+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.881+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.886+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.886+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.886+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:07.886+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:07.891+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:07.891+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:07.901+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=6[0m
07-13 10:37:07.901+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1
07-13 10:37:08.811+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2800003 time=51912240
07-13 10:37:08.821+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=51912240
07-13 10:37:09.186+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51913513 button=1
07-13 10:37:09.251+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:09.251+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:09.251+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: select_candidate(3467) > [0;36mSTART[0m
07-13 10:37:09.251+0800 E/SWIFTKEY(  668): isf_swiftkey_imengine_chinese.cpp: select_candidate_chinese(322) > [0;31m length[0, 0][0m
07-13 10:37:09.361+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:37:09.371+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=7[0m
07-13 10:37:09.376+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:37:09.376+0800 E/EFL     (17378): elementary<17378> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4451d850 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:37:09.376+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:09.376+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:09.381+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:09.381+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:09.381+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:09.381+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:09.386+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:37:09.386+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:37:09.916+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=51914192 button=1
07-13 10:37:09.916+0800 E/EFL     (17378): ecore_x<17378> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=51914246 button=1
07-13 10:37:09.921+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:09.921+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:09.926+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:09.926+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:09.941+0800 I/ISE_MULTI(  803): isemain.cpp: slot_reset_ise_input_context(1372) > [0;36m[hidden state:false][0m
07-13 10:37:09.941+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:09.941+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:09.946+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:37:09.971+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:37:10.276+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:37:10.306+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[806] goes to (3)
07-13 10:37:10.306+0800 E/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 806)'s state(3)
07-13 10:37:10.306+0800 W/AUL_AMD (  520): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-13 10:37:10.306+0800 W/AUL_AMD (  520): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
07-13 10:37:10.306+0800 W/AUL     (  520): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(806) status(fg) type(uiapp)
07-13 10:37:10.326+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: rotary_input_clear(129) > [0;31mrotary_input_clear[0m
07-13 10:37:10.326+0800 I/efl-extension(  803): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
07-13 10:37:10.326+0800 I/efl-extension(  803): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
07-13 10:37:10.326+0800 I/efl-extension(  803): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
07-13 10:37:10.326+0800 E/ISE_MULTI(  803): rotary_input.cpp: destroy_rotary_input_layout(755) > [0;31mdestroy_rotary_input_layout[0m
07-13 10:37:10.326+0800 E/ISE_MULTI(  803): ise-ui.cpp: destroy_indicator(1517) > [0;31mdestroy_indicator[0m
07-13 10:37:10.351+0800 W/AUL_PAD ( 1314): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 17378 pgid = 17378
07-13 10:37:10.351+0800 W/AUL_PAD ( 1314): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
07-13 10:37:10.356+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(986) > [0;36m-----candidate_show-----[0m
07-13 10:37:10.356+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1008) > [0;36mcandidate_show:is_chinese = 1[0m
07-13 10:37:10.356+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1034) > [0;36m-----END-----[0m
07-13 10:37:10.356+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(986) > [0;36m-----candidate_show-----[0m
07-13 10:37:10.356+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1008) > [0;36mcandidate_show:is_chinese = 1[0m
07-13 10:37:10.356+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1034) > [0;36m-----END-----[0m
07-13 10:37:10.416+0800 W/CRASH_MANAGER(17496): worker.c: worker_job(1205) > 111737873656e149991342
