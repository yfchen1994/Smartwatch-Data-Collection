S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 4900
Date: 2017-07-11 20:37:46+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4900, uid 5000)

Register Information
r0   = 0xffffffea, r1   = 0x00000025
r2   = 0xbe9ea304, r3   = 0xffffffea
r4   = 0xfbad8001, r5   = 0xbe9e9dd0
r6   = 0xbe9ea304, r7   = 0x405ab000
r8   = 0x00000000, r9   = 0xbe9ea304
r10  = 0xffffffea, fp   = 0xbe9e9dc4
ip   = 0x4008ca1c, sp   = 0xbe9e9848
lr   = 0x404baf50, pc   = 0x404f7928
cpsr = 0x20000010

Memory Information
MemTotal:   491132 KB
MemFree:      7520 KB
Buffers:     28636 KB
Cached:     161300 KB
VmPeak:      84476 KB
VmSize:      82440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24016 KB
VmRSS:       24016 KB
VmData:      18904 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25416 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4900 TID = 4900
4900 5041 

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
41923000 4192b000 r-xp /usr/lib/libdrm.so.2.4.0
41933000 41935000 r-xp /usr/lib/libdri2.so.0.0.0
4193d000 41943000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4194b000 41950000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41958000 41971000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41979000 4199a000 r-xp /usr/lib/libexif.so.12.3.3
419ad000 419af000 r-xp /usr/lib/libttrace.so.1.1
419b7000 419bc000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
419c4000 419ca000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
419d7000 41b0b000 rw-p [heap]
41b0b000 41c93000 r-xp /usr/lib/libicui18n.so.57.1
41ca3000 41da9000 r-xp /usr/lib/libicuuc.so.57.1
43658000 43660000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43668000 4368a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43693000 4369a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436a3000 436a5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436ad000 436b4000 r-xp /usr/lib/libminizip.so.1.0.0
436bc000 436c9000 r-xp /usr/lib/libail.so.0.1.0
436d2000 436d8000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e0000 436e1000 r-xp /usr/lib/libresponse.so.0.2.96
436e9000 436ee000 r-xp /usr/lib/libsystem.so.0.0.0
436f8000 437c2000 r-xp /usr/lib/libCOREGL.so.4.0
43c67000 43c72000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c7b000 43c80000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c88000 43c9f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43cac000 43cae000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43cb7000 444b6000 rw-p [stack:5041]
444b6000 444b7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
449d8000 449d9000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
449f7000 449ff000 r-xp /usr/lib/libfeedback.so.0.1.4
44a01000 44a02000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44a0a000 44a0c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44a14000 44a1f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44a27000 44a2e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44a36000 44a4e000 r-xp /usr/lib/libmmfsound.so.0.1.0
44a5f000 44a63000 r-xp /usr/lib/libmmfsession.so.0.0.0
44a6c000 44a77000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44a84000 44a88000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44a90000 44aa6000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44aae000 44b0f000 r-xp /usr/lib/libasound.so.2.0.0
44b19000 44b1c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44b24000 44b5c000 r-xp /usr/lib/libpulse.so.0.16.2
44b5d000 44b60000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44b68000 44bb0000 r-xp /usr/lib/libmdm.so.1.2.62
44bb1000 44bb4000 r-xp /usr/lib/libtinycompress.so.0.0.0
44bbc000 44bc1000 r-xp /usr/lib/libjson.so.0.0.1
44bc9000 44c12000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44c1b000 44c62000 r-xp /usr/lib/libsndfile.so.1.0.26
44c6e000 44c7d000 r-xp /usr/lib/libmdm-common.so.1.1.22
44c86000 44ca8000 r-xp /usr/lib/libvorbis.so.0.4.3
44cb0000 44cb4000 r-xp /usr/lib/libogg.so.0.7.1
be9ca000 be9eb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4900)
Call Stack Count: 1
 0: strchrnul + 0x14 (0x404f7928) [/lib/libc.so.6] + 0x7a928
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
67) >  nNewFocus[-1], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[1], HideNextPage[0], ItemListSize[34]
07-11 20:37:39.940+0800 W/APPS    (  807): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-11 20:37:39.940+0800 W/APPS    (  807): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-11 20:37:40.040+0800 I/efl-extension(  807): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-11 20:37:40.040+0800 I/efl-extension(  807): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x46142708, elm_layout, time_stamp : 4244005
07-11 20:37:40.040+0800 W/APPS    (  807): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3697) >  EditMode[0], focusPage[0], focusIndex[0], ItemList size[34], FocusPrev[0], FocusNext[0], FocusRecent[1], HideNextPage[0]
07-11 20:37:40.040+0800 W/AUL_AMD (  522): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
07-11 20:37:40.040+0800 W/AUL_AMD (  522): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
07-11 20:37:40.045+0800 W/APPS    (  807): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-11 20:37:40.045+0800 W/APPS    (  807): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
07-11 20:37:40.215+0800 I/efl-extension(  807): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
07-11 20:37:40.215+0800 I/efl-extension(  807): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x46142708, elm_layout, time_stamp : 4244180
07-11 20:37:40.215+0800 W/APPS    (  807): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3697) >  EditMode[0], focusPage[0], focusIndex[0], ItemList size[34], FocusPrev[0], FocusNext[0], FocusRecent[1], HideNextPage[0]
07-11 20:37:40.215+0800 W/APPS    (  807): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3701) >  end effect
07-11 20:37:40.715+0800 W/APPS    (  807): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5004) >  auto launch is disabled
07-11 20:37:40.865+0800 E/EFL     (  807): ecore_x<807> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4244835 button=1
07-11 20:37:40.865+0800 W/APPS    (  807): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [250, 75]
07-11 20:37:40.870+0800 E/W_HOME  (  807): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
07-11 20:37:40.925+0800 E/EFL     (  807): ecore_x<807> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4244895 button=1
07-11 20:37:40.925+0800 W/APPS    (  807): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [250, 75]->[244, 78]
07-11 20:37:40.925+0800 E/APPS    (  807): AppsViewNecklace.cpp: __GetAppsItemByTouchIndex(6907) >  Can't Find AppsItem at [-1]
07-11 20:37:40.925+0800 W/APPS    (  807): AppsViewNecklace.cpp: runFocusAni(3467) >  nNewFocus[0], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[1], HideNextPage[0], ItemListSize[34]
07-11 20:37:40.925+0800 E/APPS    (  807): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
07-11 20:37:40.930+0800 W/APPS    (  807): AppsViewNecklace.cpp: onClickedRecentApps(3232) >  item(WDS_TASKMGR_BUTTON2_RECENT_APPS_ABB) launched, open(0)
07-11 20:37:40.930+0800 W/AUL     (  807): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-taskmanager)
07-11 20:37:40.935+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 0
07-11 20:37:40.935+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(1782) > caller pid : 807
07-11 20:37:40.935+0800 I/AUL_AMD (  522): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-11 20:37:40.945+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(2218) > pad pid(-5)
07-11 20:37:40.945+0800 W/AUL_PAD ( 1295): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-11 20:37:40.945+0800 W/AUL_PAD ( 1295): launchpad.c: __send_result_to_caller(272) > Check app launching
07-11 20:37:40.950+0800 W/AUL     ( 4812): smack_util.c: set_app_smack_label(242) > thr_cnt: 2, signal count: 2,  try count 1, launchpad type: 1
07-11 20:37:40.950+0800 W/AUL_PAD ( 4812): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-11 20:37:40.950+0800 W/AUL_PAD ( 4812): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-11 20:37:40.950+0800 W/AUL_PAD ( 4812): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-11 20:37:40.950+0800 W/AUL_PAD ( 4812): launchpad_loader.c: main(680) > [candidate] dlopen(com.samsung.w-taskmanager)
07-11 20:37:40.965+0800 W/AUL_PAD ( 4812): launchpad_loader.c: main(690) > [candidate] dlsym
07-11 20:37:40.965+0800 W/AUL_PAD ( 4812): launchpad_loader.c: main(694) > [candidate] dl_main(com.samsung.w-taskmanager)
07-11 20:37:40.965+0800 I/CAPI_APPFW_APPLICATION( 4812): app_main.c: app_efl_main(129) > app_efl_main
07-11 20:37:40.970+0800 I/CAPI_APPFW_APPLICATION( 4812): app_main.c: app_appcore_create(152) > app_appcore_create
07-11 20:37:41.050+0800 W/AUL     (  522): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(com.samsung.w-taskmanager) pid(4812) type(uiapp) bg(0)
07-11 20:37:41.050+0800 W/AUL_AMD (  522): amd_status.c: __socket_monitor_cb(1277) > (4812) was created
07-11 20:37:41.050+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-11 20:37:41.050+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [4812]
07-11 20:37:41.050+0800 W/AUL     (  807): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4812)
07-11 20:37:41.050+0800 W/W_HOME  (  807): util.c: apps_util_launch_main_operation(643) > Launch app:[WDS_TASKMGR_BUTTON2_RECENT_APPS_ABB] ret:[0]
07-11 20:37:41.090+0800 I/efl-extension( 4812): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 20:37:41.090+0800 I/efl-extension( 4812): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 20:37:41.090+0800 I/efl-extension( 4812): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-11 20:37:41.090+0800 I/efl-extension( 4812): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-11 20:37:41.095+0800 I/efl-extension( 4812): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-11 20:37:41.095+0800 I/efl-extension( 4812): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4508c0a0, elm_image, _activated_obj : 0x0, activated : 1
07-11 20:37:41.125+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 20:37:41.125+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] cw(360), ch(360), pw(360), ph(360)
07-11 20:37:41.125+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-11 20:37:41.125+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 20:37:41.125+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] cw(360), ch(360), pw(360), ph(360)
07-11 20:37:41.125+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-11 20:37:41.145+0800 E/W_TASKMANAGER( 4812): util_wc1.c: close_button_disabled_set(377) > [close_button_disabled_set:377] (ad->ly_main == NULL) -> close_button_disabled_set() return
07-11 20:37:41.185+0800 E/W_TASKMANAGER( 4812): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
07-11 20:37:41.185+0800 E/W_TASKMANAGER( 4812): taskmanager.c: _app_create(324) > [_app_create:324] cannot init pkgmgr
07-11 20:37:41.325+0800 I/capability-manager( 5015): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
07-11 20:37:41.325+0800 I/capability-manager( 5015): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
07-11 20:37:41.330+0800 E/W_TASKMANAGER( 4812): task.c: _app_list_cb(609) > [_app_list_cb:609] pkgmgrinfo_appinfo_get_label(com.samsung.skmsa) failed(0)
07-11 20:37:41.335+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-home)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth.widget.pedometer)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-calendar2.widget.monthly)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.weather-widget)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-player.widget)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (health-data-service)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-music-player.music-control-service)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.shealth-service)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.remote-sensor-service)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.wusvc)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.watchface-service)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.message.consumer)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.weip.consumer)!!
07-11 20:37:41.335+0800 E/W_TASKMANAGER( 4812): task.c: _iterfunc(651) > [_iterfunc:651] Fail to get ai table (com.samsung.w-taskmanager)!!
07-11 20:37:41.340+0800 E/RUA     ( 4812): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 15, ncols : 5
07-11 20:37:41.355+0800 E/EFL     ( 4812): evas_main<4812> evas_stack.c:158 evas_object_stack_above() BITCH! evas_object_stack_above(), 0x46d056f8 not inside same smart as 0x450c7bc8!
07-11 20:37:41.355+0800 E/EFL     ( 4812): elementary<4812> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x4509ddc0 into part 'elm.swallow.event.0'
07-11 20:37:41.385+0800 W/W_HOME  (  807): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
07-11 20:37:41.385+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 20:37:41.385+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 20:37:41.385+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 20:37:41.385+0800 W/W_HOME  (  807): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-11 20:37:41.385+0800 W/W_HOME  (  807): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
07-11 20:37:41.390+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 20:37:41.415+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 20:37:41.425+0800 I/APP_CORE( 4812): appcore-efl.c: __do_app(453) > [APP 4812] Event: RESET State: CREATED
07-11 20:37:41.425+0800 I/CAPI_APPFW_APPLICATION( 4812): app_main.c: app_appcore_reset(245) > app_appcore_reset
07-11 20:37:41.440+0800 I/APP_CORE( 4812): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-11 20:37:41.440+0800 I/APP_CORE( 4812): appcore-efl.c: __do_app(524) > [APP 4812] Initial Launching, call the resume_cb
07-11 20:37:41.440+0800 I/CAPI_APPFW_APPLICATION( 4812): app_main.c: app_appcore_resume(223) > app_appcore_resume
07-11 20:37:41.455+0800 W/APP_CORE( 4812): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600003
07-11 20:37:41.470+0800 I/MALI    ( 4812): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
07-11 20:37:41.515+0800 W/W_HOME  (  807): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
07-11 20:37:41.515+0800 W/W_HOME  (  807): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
07-11 20:37:41.515+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 20:37:41.515+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 20:37:41.515+0800 W/W_HOME  (  807): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
07-11 20:37:41.515+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: PAUSE State: RUNNING
07-11 20:37:41.515+0800 I/CAPI_APPFW_APPLICATION(  807): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-11 20:37:41.515+0800 W/W_HOME  (  807): main.c: _appcore_pause_cb(487) > appcore pause
07-11 20:37:41.515+0800 W/W_HOME  (  807): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
07-11 20:37:41.515+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 20:37:41.515+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 20:37:41.515+0800 W/W_HOME  (  807): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
07-11 20:37:41.515+0800 W/W_HOME  (  807): rotary.c: rotary_deattach(156) > rotary_deattach:0x46142708
07-11 20:37:41.515+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-11 20:37:41.515+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46142708, elm_layout, func : 0x4005653d
07-11 20:37:41.515+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
07-11 20:37:41.515+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
07-11 20:37:41.515+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-11 20:37:41.515+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460e3dd0, elm_box, _activated_obj : 0x46142708, activated : 1
07-11 20:37:41.515+0800 I/efl-extension(  807): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 20:37:41.515+0800 E/wnotib  (  807): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-11 20:37:41.515+0800 I/wnotib  (  807): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
07-11 20:37:41.525+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(807) status(bg) type(uiapp)
07-11 20:37:41.525+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(4812) status(fg) type(uiapp)
07-11 20:37:41.525+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[807] goes to (4)
07-11 20:37:41.525+0800 E/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 807)'s state(4)
07-11 20:37:41.530+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4812] goes to (3)
07-11 20:37:41.545+0800 W/W_INDICATOR(  755): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-11 20:37:41.550+0800 W/W_HOME  (  807): win.c: win_back_gesture_disable_set(173) > enable back gesture
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-11 20:37:41.555+0800 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-11 20:37:41.555+0800 E/CAPI_APPFW_APP_CONTROL( 1014): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-11 20:37:41.555+0800 W/MUSIC_CONTROL_SERVICE( 1014): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1014]   [com.samsung.w-home]register msg port [false][0m
07-11 20:37:41.570+0800 I/wnotib  (  807): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-11 20:37:41.570+0800 E/wnotib  (  807): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-11 20:37:41.570+0800 W/wnotib  (  807): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
07-11 20:37:41.585+0800 W/W_INDICATOR(  755): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-11 20:37:41.600+0800 I/APP_CORE( 4812): appcore-efl.c: __do_app(453) > [APP 4812] Event: RESUME State: RUNNING
07-11 20:37:41.605+0800 W/APPS    (  807): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
07-11 20:37:41.925+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-11 20:37:42.000+0800 I/MALI    ( 4812): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414600b8] swap changed from async to sync
07-11 20:37:42.045+0800 E/EFL     ( 4812): ecore_x<4812> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4246014 button=1
07-11 20:37:42.045+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4506e9d8 : elm_scroller] mouse move
07-11 20:37:42.060+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: MEM_FLUSH State: PAUSED
07-11 20:37:42.065+0800 E/EFL     ( 4812): ecore_x<4812> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4246032 button=1
07-11 20:37:42.115+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 20:37:42.125+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
07-11 20:37:42.130+0800 W/AUL     ( 4812): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensordatacollection)
07-11 20:37:42.130+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 0
07-11 20:37:42.130+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(1782) > caller pid : 4812
07-11 20:37:42.130+0800 I/AUL_AMD (  522): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
07-11 20:37:42.155+0800 W/AUL_AMD (  522): amd_launch.c: _start_app(2218) > pad pid(-5)
07-11 20:37:42.155+0800 W/AUL_PAD ( 1295): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
07-11 20:37:42.155+0800 W/AUL_PAD ( 1295): launchpad.c: __send_result_to_caller(272) > Check app launching
07-11 20:37:42.155+0800 W/AUL_PAD ( 4900): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
07-11 20:37:42.160+0800 W/AUL_PAD ( 4900): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
07-11 20:37:42.160+0800 W/AUL_PAD ( 4900): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
07-11 20:37:42.160+0800 W/AUL_PAD ( 4900): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensordatacollection)
07-11 20:37:42.185+0800 E/RESOURCED(  630): block.c: block_prelaunch_state(138) > insert data org.example.sensordatacollection, table num : 1
07-11 20:37:42.240+0800 I/efl-extension( 4900): efl_extension.c: eext_mod_init(40) > Init
07-11 20:37:42.240+0800 I/UXT     ( 4900): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-11 20:37:42.260+0800 W/AUL_PAD ( 4900): launchpad_loader.c: main(690) > [candidate] dlsym
07-11 20:37:42.260+0800 W/AUL_PAD ( 4900): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensordatacollection)
07-11 20:37:42.260+0800 I/CAPI_APPFW_APPLICATION( 4900): app_main.c: ui_app_main(704) > app_efl_main
07-11 20:37:42.265+0800 I/CAPI_APPFW_APPLICATION( 4900): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
07-11 20:37:42.355+0800 W/AUL     (  522): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensordatacollection) pid(4900) type(uiapp) bg(0)
07-11 20:37:42.355+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 20:37:42.365+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4812
07-11 20:37:42.365+0800 W/AUL_AMD (  522): amd_status.c: __socket_monitor_cb(1277) > (4900) was created
07-11 20:37:42.365+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 20:37:42.370+0800 W/AUL     ( 4812): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4900)
07-11 20:37:42.370+0800 E/W_TASKMANAGER( 4812): task.c: taskmanager_launch_task_info(1075) > [taskmanager_launch_task_info:1075] _launch_app() failed(4900)
07-11 20:37:42.370+0800 W/STARTER (  754): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [4900]
07-11 20:37:42.380+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4812
07-11 20:37:42.380+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 20:37:42.380+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-11 20:37:42.385+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 20:37:42.435+0800 I/efl-extension( 4900): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 20:37:42.435+0800 I/efl-extension( 4900): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
07-11 20:37:42.435+0800 I/efl-extension( 4900): efl_extension_rotary.c: _init_Xi2_system(314) > In
07-11 20:37:42.435+0800 I/efl-extension( 4900): efl_extension_rotary.c: _init_Xi2_system(375) > Done
07-11 20:37:42.435+0800 I/efl-extension( 4900): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437e8f00, elm_image, _activated_obj : 0x0, activated : 1
07-11 20:37:42.440+0800 E/EFL     ( 4900): elementary<4900> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 20:37:42.445+0800 E/EFL     ( 4900): elementary<4900> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x437e9368) will be pushed
07-11 20:37:42.445+0800 I/efl-extension( 4900): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x438ad578]'s widget[0x437ea7f8] to layout widget[0x437e9368]
07-11 20:37:42.450+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d8910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 20:37:42.450+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d8910 : elm_genlist] cw(0), ch(0), pw(1), ph(1)
07-11 20:37:42.450+0800 I/efl-extension( 4900): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 20:37:42.455+0800 I/APP_CORE( 4900): appcore-efl.c: __do_app(453) > [APP 4900] Event: RESET State: CREATED
07-11 20:37:42.455+0800 I/CAPI_APPFW_APPLICATION( 4900): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
07-11 20:37:42.480+0800 I/APP_CORE( 4900): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
07-11 20:37:42.480+0800 I/APP_CORE( 4900): appcore-efl.c: __do_app(524) > [APP 4900] Initial Launching, call the resume_cb
07-11 20:37:42.480+0800 I/CAPI_APPFW_APPLICATION( 4900): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
07-11 20:37:42.515+0800 W/APP_CORE( 4900): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200002
07-11 20:37:42.520+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d8910 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 20:37:42.520+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d8910 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
07-11 20:37:42.535+0800 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
07-11 20:37:42.565+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x437d8910 : elm_genlist] mx(0), my(260), minx(0), miny(0), px(0), py(0)
07-11 20:37:42.565+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x437d8910 : elm_genlist] cw(360), ch(620), pw(360), ph(360)
07-11 20:37:42.620+0800 I/APP_CORE( 4812): appcore-efl.c: __do_app(453) > [APP 4812] Event: PAUSE State: RUNNING
07-11 20:37:42.620+0800 I/CAPI_APPFW_APPLICATION( 4812): app_main.c: app_appcore_pause(202) > app_appcore_pause
07-11 20:37:42.630+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(4812) status(bg) type(uiapp)
07-11 20:37:42.635+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4812] goes to (4)
07-11 20:37:42.635+0800 W/STARTER (  754): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4900] goes to (3)
07-11 20:37:42.635+0800 W/AUL     (  522): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensordatacollection) pid(4900) status(fg) type(uiapp)
07-11 20:37:42.655+0800 E/TBM     (  461): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:461] error(Device or resource busy) _tgl_destroy:141 key:30
07-11 20:37:42.660+0800 I/APP_CORE( 4900): appcore-efl.c: __do_app(453) > [APP 4900] Event: RESUME State: RUNNING
07-11 20:37:42.665+0800 I/efl-extension( 5020): efl_extension.c: eext_mod_init(40) > Init
07-11 20:37:42.735+0800 I/UXT     ( 5020): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
07-11 20:37:42.820+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 22
07-11 20:37:42.820+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(999) > app status : 4
07-11 20:37:42.830+0800 E/APP_CORE( 4812): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
07-11 20:37:42.830+0800 I/APP_CORE( 4812): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
07-11 20:37:42.830+0800 I/CAPI_APPFW_APPLICATION( 4812): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
07-11 20:37:42.835+0800 I/efl-extension( 4812): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x4506e9d8, obj: 0x4506e9d8
07-11 20:37:42.835+0800 I/efl-extension( 4812): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
07-11 20:37:42.835+0800 I/efl-extension( 4812): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
07-11 20:37:42.835+0800 I/efl-extension( 4812): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
07-11 20:37:42.835+0800 I/efl-extension( 4812): efl_extension_rotary.c: _object_deleted_cb(618) > done
07-11 20:37:42.840+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-11 20:37:42.840+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] cw(0), ch(0), pw(360), ph(360)
07-11 20:37:42.840+0800 E/EFL     ( 4812): elementary<4812> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x4506e9d8 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
07-11 20:37:42.840+0800 I/efl-extension( 4812): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x4508c0a0
07-11 20:37:42.840+0800 I/efl-extension( 4812): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
07-11 20:37:42.840+0800 I/efl-extension( 4812): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x450aec48 is freed
07-11 20:37:42.845+0800 I/efl-extension( 4812): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-11 20:37:42.845+0800 I/efl-extension( 4812): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4506e9d8, elm_scroller, func : 0x43912351
07-11 20:37:42.845+0800 I/efl-extension( 4812): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-11 20:37:42.845+0800 I/efl-extension( 4812): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
07-11 20:37:42.845+0800 I/efl-extension( 4812): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4508c0a0, elm_image, func : 0x43912351
07-11 20:37:42.845+0800 I/efl-extension( 4812): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
07-11 20:37:42.845+0800 I/efl-extension( 4812): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0x4506e9d8 : elm_scroller] rotary callabck is deleted
07-11 20:37:42.900+0800 I/AUL_PAD ( 5020): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-11 20:37:42.940+0800 E/MALI    ( 5020): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
07-11 20:37:42.940+0800 E/MALI    ( 5020): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
07-11 20:37:42.940+0800 E/MALI    ( 5020): [gpu-ddk] devel/graphics_drv/r4p0
07-11 20:37:42.940+0800 E/MALI    ( 5020): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
07-11 20:37:42.940+0800 E/MALI    ( 5020): [coregl] devel/graphics_engine/master
07-11 20:37:42.940+0800 E/MALI    ( 5020): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
07-11 20:37:42.940+0800 E/MALI    ( 5020): 
07-11 20:37:43.000+0800 I/APP_CORE( 4812): appcore-efl.c: __after_loop(1243) > [APP 4812] After terminate() callback
07-11 20:37:43.020+0800 I/MALI    ( 4812): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
07-11 20:37:43.020+0800 I/MALI    ( 4812): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=4812   close drm_fd=23 
07-11 20:37:43.020+0800 I/MALI    ( 4812): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
07-11 20:37:43.065+0800 E/AUL     (  522): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-11 20:37:43.425+0800 E/EFL     ( 4900): ecore_x<4900> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4247390 button=1
07-11 20:37:43.425+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.425+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.425+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:43.435+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.435+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:43.445+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.445+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:43.455+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.455+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:43.455+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] add hold animator
07-11 20:37:43.470+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.470+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:43.470+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x437d8910 : elm_genlist] direction_x(0), direction_y(1)
07-11 20:37:43.470+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:3878 _elm_scroll_hold_animator() [0x437d8910 : elm_genlist] drag_child_locked_y(0)
07-11 20:37:43.470+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x437d8910 : elm_genlist] move content x(0), y(58)
07-11 20:37:43.530+0800 E/EFL     ( 4900): ecore_x<4900> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4247492 button=1
07-11 20:37:43.530+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.530+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:43.530+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.530+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:43.530+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.530+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:43.530+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:43.530+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:43.575+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 20:37:43.585+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4900
07-11 20:37:43.590+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 20:37:43.605+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 14
07-11 20:37:43.620+0800 W/AUL_AMD (  522): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4900
07-11 20:37:43.620+0800 W/AUL_AMD (  522): amd_request.c: __request_handler(669) > __request_handler: 12
07-11 20:37:43.890+0800 I/AUL_PAD ( 5029): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-11 20:37:44.055+0800 I/UXT     ( 4812): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
07-11 20:37:44.055+0800 I/UXT     ( 4812): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
07-11 20:37:44.055+0800 I/UXT     ( 4812): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
07-11 20:37:44.260+0800 E/EFL     ( 4900): ecore_x<4900> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4248232 button=1
07-11 20:37:44.265+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:44.305+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:44.305+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:44.305+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:44.305+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:44.305+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:44.305+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:44.345+0800 E/EFL     ( 4900): ecore_x<4900> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4248295 button=1
07-11 20:37:44.345+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] mouse move
07-11 20:37:44.345+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x437d8910 : elm_genlist] hold(0), freeze(0)
07-11 20:37:44.420+0800 W/AUL_PAD ( 4812): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
07-11 20:37:44.425+0800 I/efl-extension( 4812): efl_extension.c: eext_mod_shutdown(46) > Shutdown
07-11 20:37:44.635+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4812 pgid = 4812
07-11 20:37:44.635+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
07-11 20:37:44.700+0800 I/efl-extension( 4900): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
07-11 20:37:44.700+0800 I/efl-extension( 4900): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x438c0400, elm_image, _activated_obj : 0x437e8f00, activated : 1
07-11 20:37:44.700+0800 I/efl-extension( 4900): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
07-11 20:37:44.710+0800 W/AUL_PAD ( 1295): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
07-11 20:37:44.715+0800 I/AUL_AMD (  522): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4812
07-11 20:37:44.715+0800 W/AUL     (  522): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4812)
07-11 20:37:44.725+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44708b68 : elm_scroller] mx(0), my(96), minx(0), miny(0), px(0), py(0)
07-11 20:37:44.725+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44708b68 : elm_scroller] cw(0), ch(96), pw(0), ph(0)
07-11 20:37:44.750+0800 E/EFL     ( 4900): elementary<4900> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-11 20:37:44.760+0800 E/EFL     ( 4900): elementary<4900> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x446d2da0) will be pushed
07-11 20:37:44.760+0800 I/efl-extension( 4900): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x44e2eca0]'s widget[0x44e25938] to layout widget[0x446d2da0]
07-11 20:37:44.765+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44708b68 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 20:37:44.765+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44708b68 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 20:37:44.765+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44708b68 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 20:37:44.765+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44708b68 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 20:37:44.765+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x44708b68 : elm_scroller] mx(0), my(264), minx(0), miny(0), px(0), py(0)
07-11 20:37:44.765+0800 E/EFL     ( 4900): elementary<4900> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x44708b68 : elm_scroller] cw(260), ch(624), pw(260), ph(360)
07-11 20:37:44.770+0800 I/efl-extension( 4900): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-11 20:37:44.800+0800 E/EFL     ( 4900): elementary<4900> elc_naviframe.c:2796 _push_transition_cb() item(0x446d2da0) will transition
07-11 20:37:44.825+0800 W/AUL_AMD (  522): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
07-11 20:37:45.215+0800 E/EFL     ( 4900): elementary<4900> elc_naviframe.c:1193 _on_item_push_finished() item(0x437e9368) transition finished
07-11 20:37:45.215+0800 E/EFL     ( 4900): elementary<4900> elc_naviframe.c:1218 _on_item_show_finished() item(0x446d2da0) transition finished
07-11 20:37:46.240+0800 E/EFL     ( 4900): ecore_x<4900> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=4250211 button=1
07-11 20:37:46.295+0800 E/EFL     ( 4900): ecore_x<4900> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=4250266 button=1
07-11 20:37:46.295+0800 E/EFL     ( 4900): elementary<4900> elm_widget.c:4382 elm_widget_type_check() Passing Object: 0x447089f0 in function: elm_naviframe_item_pop, of type: 'rectangle' when expecting type: 'elm_naviframe'
07-11 20:37:46.560+0800 I/APP_CORE(  807): appcore-efl.c: __do_app(453) > [APP 807] Event: MEM_FLUSH State: PAUSED
07-11 20:37:46.625+0800 W/CRASH_MANAGER( 4948): worker.c: worker_job(1205) > 110490073656e149977666
