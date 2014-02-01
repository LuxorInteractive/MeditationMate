package org.wordpress.android.util;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.ImageRequest;

import org.json.JSONException;
import org.json.JSONObject;

import java.io.UnsupportedEncodingException;

/**
 * Created by nbradbury on 9/3/13.
 */
public class VolleyUtils {

    /*
     * returns REST API error string from the response in the passed VolleyError
     * for example, returns "already_subscribed" from this response:
     *  {
	 *      "error": "already_subscribed",
	 *      "message": "You are already subscribed to the specified topic."
	 *  }
     */
    public static String errStringFromVolleyError(VolleyError volleyError) {
        JSONObject json = volleyErrorToJSON(volleyError);
        if (json==null)
            return "";
        return JSONUtil.getString(json, "error");
    }

    /*
     * attempts to return JSON from a volleyError - useful for WP REST API failures, which often
     * contain JSON in the response
     */
    private static JSONObject volleyErrorToJSON(VolleyError volleyError) {
        if (volleyError==null
                || volleyError.networkResponse==null
                || volleyError.networkResponse.data==null
                || volleyError.networkResponse.headers==null)
            return null;

        String contentType = volleyError.networkResponse.headers.get("Content-Type");
        if (contentType==null || !contentType.equals("application/json"))
            return null;

        try {
            String response = new String(volleyError.networkResponse.data, "UTF-8");
            JSONObject json = new JSONObject(response);
            return json;
        } catch (UnsupportedEncodingException e) {
            return null;
        } catch (JSONException e) {
            return null;
        }
    }

    /*
     * cancel all Volley requests that aren't for images
     */
    public static void cancelAllNonImageRequests(RequestQueue requestQueue) {
        if (requestQueue==null)
            return;
        RequestQueue.RequestFilter filter = new RequestQueue.RequestFilter() {
            @Override
            public boolean apply(Request<?> request) {
                if (request instanceof ImageRequest)
                    return false;
                return true;
            }
        };
        requestQueue.cancelAll(filter);
    }

    /*
     * cancel all Volley requests
     */
    public static void cancelAllRequests(RequestQueue requestQueue) {
        if (requestQueue==null)
            return;
        RequestQueue.RequestFilter filter = new RequestQueue.RequestFilter() {
            @Override
            public boolean apply(Request<?> request) {
                return true;
            }
        };
        requestQueue.cancelAll(filter);
    }
}
