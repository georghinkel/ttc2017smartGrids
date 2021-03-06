/**
 */
package CIM.IEC61970.SCADA.impl;

import CIM.IEC61970.Core.impl.IdentifiedObjectImpl;

import CIM.IEC61970.SCADA.RemotePoint;
import CIM.IEC61970.SCADA.RemoteUnit;
import CIM.IEC61970.SCADA.SCADAPackage;

import org.eclipse.emf.common.notify.Notification;
import org.eclipse.emf.common.notify.NotificationChain;

import org.eclipse.emf.ecore.EClass;
import org.eclipse.emf.ecore.InternalEObject;

import org.eclipse.emf.ecore.impl.ENotificationImpl;

/**
 * <!-- begin-user-doc -->
 * An implementation of the model object '<em><b>Remote Point</b></em>'.
 * <!-- end-user-doc -->
 * <p>
 * The following features are implemented:
 * </p>
 * <ul>
 *   <li>{@link CIM.IEC61970.SCADA.impl.RemotePointImpl#getRemoteUnit <em>Remote Unit</em>}</li>
 * </ul>
 *
 * @generated
 */
public class RemotePointImpl extends IdentifiedObjectImpl implements RemotePoint {
	/**
	 * The cached value of the '{@link #getRemoteUnit() <em>Remote Unit</em>}' reference.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #getRemoteUnit()
	 * @generated
	 * @ordered
	 */
	protected RemoteUnit remoteUnit;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	protected RemotePointImpl() {
		super();
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	protected EClass eStaticClass() {
		return SCADAPackage.Literals.REMOTE_POINT;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public RemoteUnit getRemoteUnit() {
		if (remoteUnit != null && remoteUnit.eIsProxy()) {
			InternalEObject oldRemoteUnit = (InternalEObject)remoteUnit;
			remoteUnit = (RemoteUnit)eResolveProxy(oldRemoteUnit);
			if (remoteUnit != oldRemoteUnit) {
				if (eNotificationRequired())
					eNotify(new ENotificationImpl(this, Notification.RESOLVE, SCADAPackage.REMOTE_POINT__REMOTE_UNIT, oldRemoteUnit, remoteUnit));
			}
		}
		return remoteUnit;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public RemoteUnit basicGetRemoteUnit() {
		return remoteUnit;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public NotificationChain basicSetRemoteUnit(RemoteUnit newRemoteUnit, NotificationChain msgs) {
		RemoteUnit oldRemoteUnit = remoteUnit;
		remoteUnit = newRemoteUnit;
		if (eNotificationRequired()) {
			ENotificationImpl notification = new ENotificationImpl(this, Notification.SET, SCADAPackage.REMOTE_POINT__REMOTE_UNIT, oldRemoteUnit, newRemoteUnit);
			if (msgs == null) msgs = notification; else msgs.add(notification);
		}
		return msgs;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public void setRemoteUnit(RemoteUnit newRemoteUnit) {
		if (newRemoteUnit != remoteUnit) {
			NotificationChain msgs = null;
			if (remoteUnit != null)
				msgs = ((InternalEObject)remoteUnit).eInverseRemove(this, SCADAPackage.REMOTE_UNIT__REMOTE_POINTS, RemoteUnit.class, msgs);
			if (newRemoteUnit != null)
				msgs = ((InternalEObject)newRemoteUnit).eInverseAdd(this, SCADAPackage.REMOTE_UNIT__REMOTE_POINTS, RemoteUnit.class, msgs);
			msgs = basicSetRemoteUnit(newRemoteUnit, msgs);
			if (msgs != null) msgs.dispatch();
		}
		else if (eNotificationRequired())
			eNotify(new ENotificationImpl(this, Notification.SET, SCADAPackage.REMOTE_POINT__REMOTE_UNIT, newRemoteUnit, newRemoteUnit));
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public NotificationChain eInverseAdd(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
		switch (featureID) {
			case SCADAPackage.REMOTE_POINT__REMOTE_UNIT:
				if (remoteUnit != null)
					msgs = ((InternalEObject)remoteUnit).eInverseRemove(this, SCADAPackage.REMOTE_UNIT__REMOTE_POINTS, RemoteUnit.class, msgs);
				return basicSetRemoteUnit((RemoteUnit)otherEnd, msgs);
		}
		return super.eInverseAdd(otherEnd, featureID, msgs);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public NotificationChain eInverseRemove(InternalEObject otherEnd, int featureID, NotificationChain msgs) {
		switch (featureID) {
			case SCADAPackage.REMOTE_POINT__REMOTE_UNIT:
				return basicSetRemoteUnit(null, msgs);
		}
		return super.eInverseRemove(otherEnd, featureID, msgs);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public Object eGet(int featureID, boolean resolve, boolean coreType) {
		switch (featureID) {
			case SCADAPackage.REMOTE_POINT__REMOTE_UNIT:
				if (resolve) return getRemoteUnit();
				return basicGetRemoteUnit();
		}
		return super.eGet(featureID, resolve, coreType);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public void eSet(int featureID, Object newValue) {
		switch (featureID) {
			case SCADAPackage.REMOTE_POINT__REMOTE_UNIT:
				setRemoteUnit((RemoteUnit)newValue);
				return;
		}
		super.eSet(featureID, newValue);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public void eUnset(int featureID) {
		switch (featureID) {
			case SCADAPackage.REMOTE_POINT__REMOTE_UNIT:
				setRemoteUnit((RemoteUnit)null);
				return;
		}
		super.eUnset(featureID);
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public boolean eIsSet(int featureID) {
		switch (featureID) {
			case SCADAPackage.REMOTE_POINT__REMOTE_UNIT:
				return remoteUnit != null;
		}
		return super.eIsSet(featureID);
	}

} //RemotePointImpl
