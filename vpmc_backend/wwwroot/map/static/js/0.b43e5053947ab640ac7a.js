webpackJsonp([0],{f54B:function(e,t){},pzuA:function(e,t,n){"use strict";Object.defineProperty(t,"__esModule",{value:!0});var a=n("BO1k"),r=n.n(a),s=n("Xxa5"),i=n.n(s),c=n("exGp"),u=n.n(c),d=n("gyMJ"),l=n("M4fF"),o=Object(l.groupBy)([],"title"),p=Object(l.keys)(o),m={name:"GeneralAndBulletinList",data:function(){return{decreeMap:o,titles:p}},props:{open:{type:Boolean,default:!1}},created:function(){this.extendFiles()},computed:{isOpen:{get:function(){return this.open},set:function(e){this.$emit("onClose",e)}}},methods:{extendFiles:function(){var e=this;return u()(i.a.mark(function t(){var n,a,s,c,u,l,o,p;return i.a.wrap(function(t){for(;;)switch(t.prev=t.next){case 0:n=[{zh_name:"通則",type:"GeneralLaw"},{zh_name:"公報",type:"Bulletin"}],a=i.a.mark(function t(n){var a,r;return i.a.wrap(function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,d.a.File.getLawFiles({item:n.type});case 2:a=t.sent,r=a.map(function(e){return{title:n.zh_name,subtitle:e.renderName,link:"/"+e.serverRoute.slice(1)}}),e.decreeMap[n.zh_name]=r,e.titles.push(n.zh_name);case 6:case"end":return t.stop()}},t,e)}),s=!0,c=!1,u=void 0,t.prev=5,l=r()(n);case 7:if(s=(o=l.next()).done){t.next=13;break}return p=o.value,t.delegateYield(a(p),"t0",10);case 10:s=!0,t.next=7;break;case 13:t.next=19;break;case 15:t.prev=15,t.t1=t.catch(5),c=!0,u=t.t1;case 19:t.prev=19,t.prev=20,!s&&l.return&&l.return();case 22:if(t.prev=22,!c){t.next=25;break}throw u;case 25:return t.finish(22);case 26:return t.finish(19);case 27:case"end":return t.stop()}},t,e,[[5,15,19,27],[20,,22,26]])}))()}}},f={render:function(){var e=this,t=e.$createElement,n=e._self._c||t;return n("md-dialog",{attrs:{"md-active":e.isOpen},on:{"update:mdActive":function(t){e.isOpen=t},"update:md-active":function(t){e.isOpen=t}}},[n("md-dialog-title",[e._v("通則／公報")]),e._v(" "),n("md-content",{staticClass:"content"},[n("md-list",e._l(e.titles,function(t,a){return n("md-list-item",{key:a,attrs:{"md-expand":"","md-expanded":!0}},[n("span",{staticClass:"md-list-item-text"},[e._v(e._s(t))]),e._v(" "),n("md-list",{attrs:{slot:"md-expand"},slot:"md-expand"},e._l(e.decreeMap[t],function(t,a){return n("md-list-item",{key:a,staticClass:"md-inset"},[n("a",{attrs:{href:t.link,target:"_blank"}},[e._v(e._s(t.subtitle))])])}),1)],1)}),1)],1)],1)},staticRenderFns:[]};var v=n("VU/8")(m,f,!1,function(e){n("f54B")},"data-v-5cc89ee5",null);t.default=v.exports}});
//# sourceMappingURL=0.b43e5053947ab640ac7a.js.map