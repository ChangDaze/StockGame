using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace FirstTrade_
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AuthenticateRequest()//�R�W�b�o���t!!!�n�R��!
        {
            if (!Request.IsAuthenticated)//���Ҧ��\�N���h����
            {
                return;
            }

            //���ѷ|���A�T�{?�n���S���O�o��(�]�����Ҫ��a��M�ǤJ���F��n�����n����?)�A�ϥ����Ψ���@�w���A���U�������ѥi�����
            //���oFormsIdentity
            var id = (FormsIdentity)User.Identity;//�j���૬?
            //�A���X�{�Ҳ�
            FormsAuthenticationTicket ticket = id.Ticket;

            //�N�s�b�{�Ҳ��̪�userdata���X
            string roles = ticket.UserData;//��"admin, ,editor"�o�ث��A���A�B�z
            //roles�ܦ��}�C-> �h����
            string[] arrRoles = roles.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);//new char[]�O�h����K��h�ﶵ���Ϊ��}�C

            IPrincipal currentUser = new GenericPrincipal(User.Identity, arrRoles);//����role���ˤl

            Context.User = currentUser;//�|�A���Ҥ@��?
        }
    }
}
