S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.2
Build-Number: R720XXU2EQC1
Build-Date: 2017.03.13 20:33:27

Crash Information
Process Name: sensordatacollection
PID: 18021
Date: 2017-07-13 10:41:30+0800
Executable File Path: /opt/usr/apps/org.example.sensordatacollection/bin/sensordatacollection
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18021, uid 5000)

Register Information
r0   = 0xbe9fa32d, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x4458edc8, r5   = 0x4456f798
r6   = 0x445695e8, r7   = 0xbe9fa010
r8   = 0x00000000, r9   = 0x418af400
r10  = 0x4473acf0, fp   = 0x00000001
ip   = 0x414d1d80, sp   = 0xbe9f9ff0
lr   = 0x414c0109, pc   = 0x404f2cb8
cpsr = 0x80000010

Memory Information
MemTotal:   491132 KB
MemFree:     32228 KB
Buffers:     11020 KB
Cached:     136980 KB
VmPeak:      96304 KB
VmSize:      95284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23684 KB
VmRSS:       23684 KB
VmData:      18208 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25500 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18021 TID = 18021
18021 18104 

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
43c7f000 4447e000 rw-p [stack:18104]
4447e000 4447f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444d9000 444da000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444e5000 444ea000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
4494e000 44956000 r-xp /usr/lib/libfeedback.so.0.1.4
44958000 44959000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44961000 44963000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
4496b000 44976000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
4497e000 44985000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4498d000 449a5000 r-xp /usr/lib/libmmfsound.so.0.1.0
449b6000 449ba000 r-xp /usr/lib/libmmfsession.so.0.0.0
449c3000 449ce000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
449db000 449df000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
449e7000 449fd000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44a05000 44a66000 r-xp /usr/lib/libasound.so.2.0.0
44a70000 44a73000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44a7b000 44ab3000 r-xp /usr/lib/libpulse.so.0.16.2
44ab4000 44ab7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44abf000 44b07000 r-xp /usr/lib/libmdm.so.1.2.62
44b08000 44b0b000 r-xp /usr/lib/libtinycompress.so.0.0.0
44b13000 44b18000 r-xp /usr/lib/libjson.so.0.0.1
44b20000 44b69000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44b72000 44bb9000 r-xp /usr/lib/libsndfile.so.1.0.26
44bc5000 44bd4000 r-xp /usr/lib/libmdm-common.so.1.1.22
44bdd000 44bff000 r-xp /usr/lib/libvorbis.so.0.4.3
44c07000 44c0b000 r-xp /usr/lib/libogg.so.0.7.1
44c13000 44c23000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
be9da000 be9fb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18021)
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
eived(147) > MessagePort message received
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
07-13 10:41:19.926+0800 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
07-13 10:41:19.931+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
07-13 10:41:19.931+0800 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
07-13 10:41:19.931+0800 I/wnotib  (  806): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
07-13 10:41:19.931+0800 E/wnotib  (  806): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
07-13 10:41:19.931+0800 W/wnotib  (  806): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [1], notiboard card appending count [2].
07-13 10:41:19.931+0800 W/W_INDICATOR(  742): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
07-13 10:41:19.931+0800 W/W_INDICATOR(  742): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
07-13 10:41:19.931+0800 E/CAPI_APPFW_APP_CONTROL( 1010): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
07-13 10:41:19.931+0800 W/MUSIC_CONTROL_SERVICE( 1010): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1010]   [com.samsung.w-home]register msg port [false][0m
07-13 10:41:19.956+0800 W/WATCH_CORE(  929): appcore-watch.c: __widget_pause(1113) > widget_pause
07-13 10:41:19.956+0800 W/AUL     (  929): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(929) status(bg) type(watchapp)
07-13 10:41:19.956+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppPause(589) > 
07-13 10:41:20.266+0800 E/AUL     (  520): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
07-13 10:41:20.431+0800 I/APP_CORE(  806): appcore-efl.c: __do_app(453) > [APP 806] Event: MEM_FLUSH State: PAUSED
07-13 10:41:20.681+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-13 10:41:20.696+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18021
07-13 10:41:20.696+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-13 10:41:20.726+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 14
07-13 10:41:20.736+0800 W/AUL_AMD (  520): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18021
07-13 10:41:20.736+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 12
07-13 10:41:20.931+0800 I/AUL_PAD (18093): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
07-13 10:41:21.586+0800 E/EFL     (18021): ecore_x<18021> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52165914 button=1
07-13 10:41:21.586+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-13 10:41:21.611+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] mouse move
07-13 10:41:21.611+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x417e96d8 : elm_genlist] hold(0), freeze(0)
07-13 10:41:21.621+0800 E/EFL     (18021): ecore_x<18021> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=52165953 button=1
07-13 10:41:21.921+0800 E/EFL     (18021): elementary<18021> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x4452d7f0 into part 'elm.swallow.content'
07-13 10:41:21.996+0800 E/EFL     (18021): edje<18021> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:41:22.011+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] mx(30), my(40), minx(0), miny(0), px(0), py(0)
07-13 10:41:22.011+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] cw(30), ch(40), pw(0), ph(0)
07-13 10:41:22.021+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] mx(4), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:41:22.021+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] cw(4), ch(40), pw(0), ph(40)
07-13 10:41:22.021+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] mx(4), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:41:22.021+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] cw(4), ch(40), pw(0), ph(40)
07-13 10:41:22.026+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452d7f0 : elm_scroller] mx(0), my(50), minx(0), miny(0), px(0), py(0)
07-13 10:41:22.026+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452d7f0 : elm_scroller] cw(0), ch(50), pw(0), ph(0)
07-13 10:41:22.041+0800 E/EFL     (18021): elementary<18021> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
07-13 10:41:22.051+0800 E/EFL     (18021): elementary<18021> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x448067d8) will be pushed
07-13 10:41:22.051+0800 I/efl-extension(18021): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(841) > Put the surface[0x4481c3b0]'s widget[0x44808c90] to layout widget[0x448067d8]
07-13 10:41:22.056+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:41:22.056+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:41:22.056+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:41:22.056+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:41:22.056+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452d7f0 : elm_scroller] mx(360), my(360), minx(0), miny(0), px(0), py(0)
07-13 10:41:22.056+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452d7f0 : elm_scroller] cw(360), ch(360), pw(0), ph(0)
07-13 10:41:22.056+0800 I/efl-extension(18021): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
07-13 10:41:22.061+0800 E/EFL     (18021): edje<18021> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:41:22.071+0800 E/EFL     (18021): elementary<18021> elc_naviframe.c:2796 _push_transition_cb() item(0x448067d8) will transition
07-13 10:41:22.486+0800 E/EFL     (18021): elementary<18021> elc_naviframe.c:1193 _on_item_push_finished() item(0x44513aa0) transition finished
07-13 10:41:22.486+0800 E/EFL     (18021): elementary<18021> elc_naviframe.c:1218 _on_item_show_finished() item(0x448067d8) transition finished
07-13 10:41:22.496+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:22.496+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:22.496+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:22.496+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:22.496+0800 I/ISE_MULTI(  803): isemain.cpp: slot_set_return_key_disable(1252) > [0;36m[hidden state:true] disabled=0[0m
07-13 10:41:22.496+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
07-13 10:41:22.496+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
07-13 10:41:22.496+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
07-13 10:41:22.496+0800 E/TIZEN_N_SYSTEM_SETTINGS(  803): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
07-13 10:41:22.501+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:41:22.501+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1a00002 FAILED!
07-13 10:41:22.521+0800 I/ISE_MULTI(  803): isemain.cpp: slot_set_caps_mode(1113) > [0;36m[hidden state:true] mode=1[0m
07-13 10:41:22.566+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:41:22.616+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:41:22.616+0800 I/ISE_MULTI(  803): ise.cpp: ise_show(2316) > [0;36m--------BEFORE set is_candidate_on-----------[0m
07-13 10:41:22.616+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:41:22.616+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(335) > [0;36m----------START----------[0m
07-13 10:41:22.616+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(347) > [0;36m-------INPUT_MODE_HANDWRITING--------[0m
07-13 10:41:22.616+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: rotary_input_init(119) > [0;31mrotary_input_init[0m
07-13 10:41:22.621+0800 W/SWIFTKEY(  668): swiftkey_logger.cpp: reportError(44) > [0;33mSKLogger [ File Not Found : Could not read keypress model file at "/opt/usr/share/scim/swiftkey/lang/zh_CN/keyModel_qwerty_port.json" ][0m
07-13 10:41:22.621+0800 W/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Load_keymodel(2368) > [0;33mfail to set the keypress model to /opt/usr/share/scim/swiftkey/lang/zh_CN/keyModel_qwerty_port.json[0m
07-13 10:41:22.626+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1a00002 time=52166953
07-13 10:41:22.636+0800 I/ISE_MULTI(  803): ise.cpp: ise_show(2374) > [0;36m--------------------[0m
07-13 10:41:22.636+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(986) > [0;36m-----candidate_show-----[0m
07-13 10:41:22.636+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1008) > [0;36mcandidate_show:is_chinese = 1[0m
07-13 10:41:22.636+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1034) > [0;36m-----END-----[0m
07-13 10:41:22.706+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:41:22.706+0800 E/EFL     (18021): ecore_x<18021> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=52166953
07-13 10:41:22.706+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=52166953
07-13 10:41:22.711+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:41:22.731+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_hide(1039) > [0;36mcandidate_hide[0m
07-13 10:41:22.806+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:41:22.941+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52167270 button=1
07-13 10:41:23.036+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.036+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.106+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [280x300]
07-13 10:41:23.126+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.126+0800 W/STARTER (  741): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[803] goes to (3)
07-13 10:41:23.126+0800 E/AUL_AMD (  520): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
07-13 10:41:23.126+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.126+0800 E/ISE_MULTI(  803): ise-ui.cpp: indicator_popup_show_cb(1533) > [0;31mindicator_popup_show_cb[0m
07-13 10:41:23.251+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.251+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.261+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:41:23.261+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:41:23.346+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x22]
07-13 10:41:23.396+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=0[0m
07-13 10:41:23.401+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.401+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.401+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.411+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.416+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.421+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.421+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.421+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:41:23.421+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:41:23.426+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:23.426+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:23.431+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:41:23.431+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:41:23.436+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:41:23.441+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:41:23.461+0800 E/EFL     (18021): edje<18021> edje_util.c:3785 edje_object_size_min_restricted_calc() group entry_layout has a non-fixed part 'entry_part'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
07-13 10:41:23.461+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452d7f0 : elm_scroller] mx(360), my(70), minx(0), miny(0), px(0), py(0)
07-13 10:41:23.461+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452d7f0 : elm_scroller] cw(360), ch(70), pw(0), ph(0)
07-13 10:41:23.461+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:41:23.461+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:41:23.836+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52168167 button=1
07-13 10:41:23.901+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [280x300] -> [360x360]
07-13 10:41:24.016+0800 E/EFL     (  462): ecore_x<462> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x280006d time=52168244
07-13 10:41:24.016+0800 W/WATCH_CORE(  929): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
07-13 10:41:24.016+0800 I/WATCH_CORE(  929): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
07-13 10:41:24.016+0800 I/CAPI_WATCH_APPLICATION(  929): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
07-13 10:41:24.016+0800 E/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(616) > 
07-13 10:41:24.016+0800 I/watchface-loader(  929): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
07-13 10:41:24.021+0800 E/wnoti-service( 1049): wnoti-db-utility.c: context_wearonoff_status_cb(1774) > status changed from 2 to 1 
07-13 10:41:24.021+0800 E/wnoti-service( 1049): wnoti-native-client.c: handle_cache_notification(737) > >>
07-13 10:41:24.021+0800 E/WMS     (  518): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23423) > wear_monitor_status update[0] = 2 -> 1
07-13 10:41:24.021+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
07-13 10:41:24.021+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
07-13 10:41:24.021+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
07-13 10:41:24.021+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
07-13 10:41:24.021+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-13 10:41:24.031+0800 E/ALARM_MANAGER(  499): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(5), start(13-7-2017, 10:41:29), repeat(0), interval(0), type(-1073741822)
07-13 10:41:24.036+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [499].
07-13 10:41:24.051+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=52168244
07-13 10:41:24.051+0800 I/AUL     (  516): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-13 10:41:24.061+0800 W/AUL_AMD (  520): amd_request.c: __request_handler(669) > __request_handler: 15
07-13 10:41:24.071+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-13 10:41:24.081+0800 I/AUL_AMD (  520): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
07-13 10:41:24.081+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1499913689, Thu Jul 13 10:41:29 2017
07-13 10:41:24.081+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1969116402, next duetime: 1499913689
07-13 10:41:24.081+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1969116402)
07-13 10:41:24.081+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1499918348), due_time(1499913689)
07-13 10:41:24.131+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-13 10:41:24.136+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-13 10:41:24.136+0800 W/SHealthService( 1115): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
07-13 10:41:24.136+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 13-7-2017, 02:41:29 (UTC).
07-13 10:41:24.136+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-13 10:41:24.136+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:41:24.141+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-13 10:41:24.141+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:41:24.151+0800 W/WECONN  (  499): <__wc_device_on_wear_onoff_changed_cb:385> }
07-13 10:41:24.151+0800 W/WECONN  (  499): <__wc_feature_wearonoff_monitor_cb:531> }
07-13 10:41:24.286+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52168616 button=1
07-13 10:41:24.496+0800 W/SHealthService( 1115): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
07-13 10:41:24.586+0800 E/SHealthService( 1115): SContextStepLevelMonitorProxy.cpp: SOnContextStepLevelMonitorUpdatedCB(265) > [0;40;31mcontext_context_data_get_int(CONTEXT_INTERNAL_STEP_LEVEL_MONITOR_CALLBACK_MODE) failed[-22][Invalid argument][0;m
07-13 10:41:24.586+0800 W/SHealthService( 1115): SContextStepLevelMonitorProxy.cpp: OnContextStepLevelMonitorUpdated(359) > [1;40;33mOnNotWearingStop[0;m
07-13 10:41:24.701+0800 W/SHealthService( 1115): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-13 10:41:24.711+0800 W/SHealthService( 1115): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
07-13 10:41:24.731+0800 W/SHealthCommon( 1115): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1499904000000.000000[0;m
07-13 10:41:24.746+0800 W/SHealthCommon( 1115): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
07-13 10:41:24.746+0800 W/SHealthCommon( 1115): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
07-13 10:41:24.766+0800 I/HealthDataService(  998): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
07-13 10:41:24.776+0800 I/healthData( 1115): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
07-13 10:41:24.931+0800 I/APP_CORE(  806): appcore-efl.c: __do_app(453) > [APP 806] Event: MEM_FLUSH State: PAUSED
07-13 10:41:24.951+0800 E/EFL     (18021): ecore_x<18021> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1
07-13 10:41:24.961+0800 E/EFL     (18021): ecore_x<18021> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1
07-13 10:41:25.311+0800 E/ISE_HWR (  803): handwriting.cpp: efl_ise_recog_timeout(213) > [0;31mEND[0m
07-13 10:41:25.346+0800 I/MALI    (  803): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [360x360] -> [280x300]
07-13 10:41:25.386+0800 E/ISE_HWR (  803): handwriting.cpp: __hwr_result_notification_callback(857) > [0;31m============iscommited == 1[0m
07-13 10:41:27.876+0800 I/efl-extension(18021): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:41:27.876+0800 I/efl-extension(18021): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x44513638, elm_image, time_stamp : 52172202
07-13 10:41:27.876+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] mx(0), my(130), minx(0), miny(0), px(0), py(0)
07-13 10:41:27.876+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] cw(360), ch(490), pw(360), ph(360)
07-13 10:41:27.876+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x417e96d8 : elm_genlist] x(0), y(130)
07-13 10:41:27.876+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x417e96d8 : elm_genlist] t_in(0.300000), pos_x(0)
07-13 10:41:27.876+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x417e96d8 : elm_genlist] t_in(0.300000), pos_y(130)
07-13 10:41:27.876+0800 I/efl-extension(  803): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:41:27.876+0800 E/ISE_MULTI(  803): ise-rotary-event-listener.cpp: _ise_rotary_handler_cb(52) > [0;31m_ise_rotary_handler_cb[0m
07-13 10:41:27.876+0800 W/ISE_MULTI(  803): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [65542][0m
07-13 10:41:27.881+0800 I/efl-extension(  806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:41:27.881+0800 I/efl-extension( 1316): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
07-13 10:41:27.886+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.097132)
07-13 10:41:27.891+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(0)
07-13 10:41:27.891+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.097132)
07-13 10:41:27.891+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(12)
07-13 10:41:27.921+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.302385)
07-13 10:41:27.921+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(12)
07-13 10:41:27.926+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.302385)
07-13 10:41:27.926+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(39)
07-13 10:41:27.926+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.324950)
07-13 10:41:27.976+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(39)
07-13 10:41:27.976+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.324950)
07-13 10:41:27.976+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(42)
07-13 10:41:27.981+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.580785)
07-13 10:41:27.981+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(42)
07-13 10:41:27.981+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.580785)
07-13 10:41:27.981+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(75)
07-13 10:41:27.981+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.591644)
07-13 10:41:27.981+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(75)
07-13 10:41:27.981+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.591644)
07-13 10:41:27.981+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(76)
07-13 10:41:27.996+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.600072)
07-13 10:41:27.996+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(76)
07-13 10:41:27.996+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.600072)
07-13 10:41:28.001+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(78)
07-13 10:41:28.001+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.669619)
07-13 10:41:28.001+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(78)
07-13 10:41:28.001+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.669619)
07-13 10:41:28.001+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(87)
07-13 10:41:28.001+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.678303)
07-13 10:41:28.001+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(87)
07-13 10:41:28.001+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.678303)
07-13 10:41:28.016+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(88)
07-13 10:41:28.021+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.736819)
07-13 10:41:28.021+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(88)
07-13 10:41:28.021+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.736819)
07-13 10:41:28.021+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(95)
07-13 10:41:28.036+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.789123)
07-13 10:41:28.036+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(95)
07-13 10:41:28.036+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.789123)
07-13 10:41:28.036+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(102)
07-13 10:41:28.051+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.837053)
07-13 10:41:28.051+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(102)
07-13 10:41:28.051+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.837053)
07-13 10:41:28.056+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(108)
07-13 10:41:28.071+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.878819)
07-13 10:41:28.071+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(108)
07-13 10:41:28.071+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.878819)
07-13 10:41:28.071+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_RENEW : px(0), py(114)
07-13 10:41:28.076+0800 E/ISE_MULTI(  803): rotary_input.cpp: destroy_rotary_input_layout(755) > [0;31mdestroy_rotary_input_layout[0m
07-13 10:41:28.076+0800 I/ISE_MULTI(  803): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[1],xt9Context.xt9OnOff[1],gFPredictionDisabled[0] [0m
07-13 10:41:28.076+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(335) > [0;36m----------START----------[0m
07-13 10:41:28.076+0800 I/ISE_MULTI(  803): ise.cpp: relocate_main_window(347) > [0;36m-------INPUT_MODE_HANDWRITING--------[0m
07-13 10:41:28.116+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(986) > [0;36m-----candidate_show-----[0m
07-13 10:41:28.116+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1008) > [0;36mcandidate_show:is_chinese = 1[0m
07-13 10:41:28.116+0800 I/CANDIDATE(  803): soft_candidate.cpp: ui_candidate_show(1034) > [0;36m-----END-----[0m
07-13 10:41:28.121+0800 W/ISF_PANEL_EFL(  734): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x2800003 FAILED!
07-13 10:41:28.121+0800 I/ISE_MULTI(  803): privatekeys.cpp: ise_update_globe_private_key(1819) > [0;36mSystem language is [zh_CN.UTF-8] #####[0m
07-13 10:41:28.136+0800 I/ISE_MULTI(  803): privatekeys.cpp: ise_update_globe_private_key(1819) > [0;36mSystem language is [zh_CN.UTF-8] #####[0m
07-13 10:41:28.151+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:41:28.211+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] time(0.985426)
07-13 10:41:28.216+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(114)
07-13 10:41:28.216+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] time(0.985426)
07-13 10:41:28.216+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] animation stop!!
07-13 10:41:28.216+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x417e96d8 : elm_genlist] ECORE_CALLBACK_CANCEL : px(0), py(130)
07-13 10:41:28.276+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:28.276+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:28.286+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:28.286+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:28.291+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:28.291+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:28.296+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:41:28.296+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:41:28.996+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
07-13 10:41:29.006+0800 E/EFL     (  462): ecore_x<462> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52173336 button=1
07-13 10:41:29.031+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
07-13 10:41:29.076+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:29.076+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:29.081+0800 I/SWIFTKEY(  668): isf_swiftkey_imengine.cpp: select_candidate(3467) > [0;36mSTART[0m
07-13 10:41:29.081+0800 E/SWIFTKEY(  668): isf_swiftkey_imengine_chinese.cpp: select_candidate_chinese(322) > [0;31m length[0, 0][0m
07-13 10:41:29.101+0800 W/AUL     (  516): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(499) type(wakeup)
07-13 10:41:29.101+0800 E/RESOURCED(  605): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 499
07-13 10:41:29.111+0800 E/ALARM_MANAGER(  499): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [1969116402]
07-13 10:41:29.111+0800 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
07-13 10:41:29.111+0800 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
07-13 10:41:29.111+0800 W/WECONN  (  499): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
07-13 10:41:29.111+0800 W/WECONN  (  499): <__connect_for_auto_switch:1706> { device=0x42901dd8, device->bt_address=1E:F0
07-13 10:41:29.131+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_expired(1445) > alarm_id[1969116402] is expired.
07-13 10:41:29.131+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:41:29.131+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1969116402)
07-13 10:41:29.131+0800 E/ALARM_MANAGER(  516): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(1591639436) is OVER.
07-13 10:41:29.131+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
07-13 10:41:29.131+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 13-7-2017, 03:59:08 (UTC).
07-13 10:41:29.131+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
07-13 10:41:29.131+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __save_module_log(1778) > The file is not ready.
07-13 10:41:29.131+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
07-13 10:41:29.166+0800 E/ALARM_MANAGER(  516): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
07-13 10:41:29.261+0800 I/SWIFTKEY(  668): swiftkey_engine.cpp: IME_Generate_prediction_TH(1750) > [0;36mGen prediction[0m
07-13 10:41:29.266+0800 W/WECONN  (  499): <__connect_for_auto_switch:1719> }
07-13 10:41:29.266+0800 W/WECONN  (  499):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
07-13 10:41:29.266+0800 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:185> }
07-13 10:41:29.281+0800 I/ISE_MULTI(  803): isemain.cpp: slot_update_cursor_position(1172) > [0;36m[hidden state:false] pos=1[0m
07-13 10:41:29.281+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] mx(0), my(0), minx(0), miny(0), px(0), py(0)
07-13 10:41:29.281+0800 E/EFL     (18021): elementary<18021> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4452f550 : elm_entry] cw(148), ch(40), pw(148), ph(40)
07-13 10:41:29.281+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:29.281+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:29.281+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:29.281+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:29.281+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:29.281+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:29.286+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1558) > [0;36mline:1 col:0 expand:0[0m
07-13 10:41:29.286+0800 I/CANDIDATE(  803): soft_candidate.cpp: update_chinese_table(1609) > [0;36m********** line_count = 1[0m
07-13 10:41:29.981+0800 E/EFL     (18021): ecore_x<18021> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=52174275 button=1
07-13 10:41:29.981+0800 E/EFL     (18021): ecore_x<18021> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=52174311 button=1
07-13 10:41:29.991+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:29.991+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:29.996+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:29.996+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:30.011+0800 I/ISE_MULTI(  803): isemain.cpp: slot_reset_ise_input_context(1372) > [0;36m[hidden state:false][0m
07-13 10:41:30.011+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:30.011+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:30.016+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(810) > [0;36m===START ===[0m
07-13 10:41:30.016+0800 I/CANDIDATE(  803): soft_candidate.cpp: ise_candidate_collapse_candidate_window(853) > [0;36m===END ===[0m
07-13 10:41:30.341+0800 W/CRASH_MANAGER(18141): worker.c: worker_job(1205) > 111802173656e149991369
